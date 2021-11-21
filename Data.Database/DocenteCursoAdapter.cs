using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class DocenteCursoAdapter:Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> DocCur = new List<DocenteCurso>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocCur = new SqlCommand("select * from docentes_cursos", sqlConn);
                SqlDataReader drDocCur = cmdDocCur.ExecuteReader();
                while (drDocCur.Read())
                {
                    DocenteCurso dc = new DocenteCurso();
                    dc.ID = (int)drDocCur["id_dictado"];
                    dc.IdCurso = (int)drDocCur["id_curso"];
                    dc.IdDocente = (int)drDocCur["id_docente"];
                    dc.Cargo = (int)drDocCur["cargo"];
                    DocCur.Add(dc);
                }
                drDocCur.Close();
                return DocCur;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Docentes Cursos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Business.Entities.DocenteCurso GetOne(int ID)
        {
            DocenteCurso dc = new DocenteCurso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdDocCur = new SqlCommand("select * from docentes_cursos where id_dictado=@id", sqlConn);
                cmdDocCur.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drUsuarios = cmdDocCur.ExecuteReader();
                if (drUsuarios.Read())
                {
                    dc.ID = (int)drUsuarios["id_dictado"];
                    dc.IdCurso = (int)drUsuarios["id_curso"];
                    dc.IdDocente = (int)drUsuarios["id_docente"];
                    dc.Cargo = (int)drUsuarios["cargo"];
                }
                drUsuarios.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar al docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return dc;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete docentes_cursos where id_dictado=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(DocenteCurso dc)
        {
            if (dc.State == BusinessEntity.States.Deleted)
            {
                this.Delete(dc.ID);
            }
            else if (dc.State == BusinessEntity.States.New)
            {
                this.Insert(dc);
            }
            else if (dc.State == BusinessEntity.States.Modified)
            {
                this.Update(dc);
            }
            dc.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE docentes_cursos SET id_curso = @id_curso, id_docente=@id_docente, " +
                    "cargo = @cargo " + "WHERE id_dictado=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = dc.ID;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = dc.IdCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = dc.IdDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = dc.Cargo;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del docente curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO docentes_cursos(id_curso,id_docente,cargo) " +
                    "VALUES(@id_curso,@id_docente,@cargo) " +
                    "SELECT @@identity", sqlConn);
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = dc.IdCurso;
                cmdSave.Parameters.Add("@id_docente", SqlDbType.Int).Value = dc.IdDocente;
                cmdSave.Parameters.Add("@cargo", SqlDbType.Int).Value = dc.Cargo;
                dc.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());//asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear un Docente Curso", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
