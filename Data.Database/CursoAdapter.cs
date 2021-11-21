using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
        #region DatosEnMemoria
        private static List<Curso> _Cursos;
        private static List<Curso> Cursos
        {
            get
            {
                if (_Cursos == null)
                {
                    _Cursos = new List<Curso>();
                    Business.Entities.Curso cur;
                    cur = new Business.Entities.Curso();
                    cur.ID = 1;
                    cur.State = Business.Entities.BusinessEntity.States.Unmodified;
                    cur.AnioCalendario = 2021;
                    cur.Cupo = 30;
                    cur.Descripcion = "Matematicas";
                    cur.IdComision = 106;
                    cur.IdMateria = 16;
                    _Cursos.Add(cur);

                    cur = new Business.Entities.Curso();
                    cur.ID = 2;
                    cur.State = Business.Entities.BusinessEntity.States.Unmodified;
                    cur.AnioCalendario = 2021;
                    cur.Cupo = 30;
                    cur.Descripcion = "Ingles";
                    cur.IdComision = 102;
                    cur.IdMateria = 12;
                    _Cursos.Add(cur);
                }
                return _Cursos;
            }
        }
        #endregion
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos", sqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cur = new Curso();
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IdComision= (int)drCursos["id_comision"];
                    cur.IdMateria = (int)drCursos["id_materia"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cursos.Add(cur);
                }
                drCursos.Close();
                return cursos;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select * from cursos where id_curso=@id", sqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                if (drCursos.Read())
                {
                    cur.ID = (int)drCursos["id_curso"];
                    cur.IdComision = (int)drCursos["id_comision"];
                    cur.IdMateria = (int)drCursos["id_materia"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    cur.Cupo = (int)drCursos["cupo"];
                }
                drCursos.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return cur;
        }

        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();
                //creame la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Curso curs)
        {
            if (curs.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curs.ID);
            }
            else if (curs.State == BusinessEntity.States.New)
            {
                this.Insert(curs);
            }
            else if (curs.State == BusinessEntity.States.Modified)
            {
                this.Update(curs);
            }
            curs.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE cursos SET id_materia = @id_materia, id_comision = @id_comision, anio_calendario = @anio_calendario, cupo = @cupo " +
                    "WHERE id_curso=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = cur.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IdMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int, 50).Value = cur.IdComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int, 50).Value = cur.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int, 50).Value = cur.Cupo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del Curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO cursos(id_materia,id_comision,anio_calendario,cupo) " +
                    "VALUES(@id_materia,@id_comision,@anio_calendario,@cupo) " +
                    "SELECT @@identity"//esta linea es para recuperar el ID que asignó el sql automaticamente
                    , sqlConn);
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IdMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int, 50).Value = cur.IdComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int, 50).Value = cur.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int, 50).Value = cur.Cupo;
                cur.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());//asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear un curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
