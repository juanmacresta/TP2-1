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
    public class MateriasAdapter : Adapter
    {
        private static List<Materia> _Materia;

        private static List<Materia> Materias
        {
            get
            {
                if (_Materia == null)
                {
                    _Materia = new List<Materia>();
                    Business.Entities.Materia mat;
                    mat = new Materia();
                    mat.ID = 1;
                    mat.State = Business.Entities.BusinessEntity.States.Unmodified;
                    mat.Descripcion = "Matematica";
                    mat.HsSemanales = 5;
                    mat.HsTotales = 40;
                    mat.IdPlan = 1;
                    _Materia.Add(mat);

                    mat = new Materia();
                    mat.ID = 2;
                    mat.State = Business.Entities.BusinessEntity.States.Unmodified;
                    mat.Descripcion = "Ingles";
                    mat.HsSemanales = 3;
                    mat.HsTotales = 50;
                    mat.IdPlan = 2;
                    _Materia.Add(mat);
                }
                return _Materia;
            }
        }

        public List<Materia> GetAll()
        {
            List<Materia> materia = new List<Materia>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select * from materias", sqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                while (drMaterias.Read())
                {
                    Materia mat = new Materia();
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.HsSemanales = (int)drMaterias["hs_semanales"];
                    mat.HsTotales= (int)drMaterias["hs_totales"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.IdPlan = (int)drMaterias["id_plan"];
                    materia.Add(mat);
                }
                drMaterias.Close();
                return materia;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Materia GetOne(int ID)
        {
            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("select * from materias where id_materia=@id", sqlConn);
                cmdMaterias.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();
                if (drMaterias.Read())
                {
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.IdPlan = (int)drMaterias["id_plan"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                    mat.HsSemanales = (int)drMaterias["hs_semanales"];
                    mat.HsTotales = (int)drMaterias["hs_totales"];
                }
                drMaterias.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return mat;
        }

        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();
                //creame la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar materias", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Materia mate)
        {
            if (mate.State == BusinessEntity.States.Deleted)
            {
                this.Delete(mate.ID);
            }
            else if (mate.State == BusinessEntity.States.New)
            {
                this.Insert(mate);
            }
            else if (mate.State == BusinessEntity.States.Modified)
            {
                this.Update(mate);
            }
            mate.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Materia mate)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE materias SET desc_materia = @desc_materia, " +
                    "id_plan = @id_plan, hs_totales = @hs_totales, hs_semanales = @hs_semanales " +
                    "WHERE id_materia=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = mate.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar).Value = mate.Descripcion;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int, 50).Value = mate.HsTotales;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int, 50).Value = mate.HsSemanales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = mate.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Materia mat)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO materias(desc_materia,hs_semanales,hs_totales,id_plan) " +
                    "VALUES(@desc_materia,@hs_semanales,@hs_totales,@id_plan) " +
                    "SELECT @@identity"//esta linea es para recuperar el ID que asignó el sql automaticamente
                    , sqlConn);
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = mat.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.VarChar, 50).Value = mat.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.VarChar, 50).Value = mat.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Bit).Value = mat.IdPlan;
                mat.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());//asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear una Materia", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
