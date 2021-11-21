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
    public class ComisionAdapter : Adapter
    {
        private static List<Comision> _Comision;

        private static List<Comision> Comisiones
        {
            get
            {
                if (_Comision == null)
                {
                    _Comision = new List<Comision>();
                    Business.Entities.Comision com;
                    com = new Business.Entities.Comision();
                    com.ID = 1;
                    com.State = Business.Entities.BusinessEntity.States.Unmodified;
                    com.AnioEspecialidad = 2021;
                    com.Descripcion = "A101";
                    com.IdPlan = 08;
                    _Comision.Add(com);

                    com = new Business.Entities.Comision();
                    com.ID = 2;
                    com.State = Business.Entities.BusinessEntity.States.Unmodified;
                    com.AnioEspecialidad = 2020;
                    com.Descripcion = "A102";
                    com.IdPlan = 08;
                    _Comision.Add(com);
                }
                return _Comision;
            }
        }

        public List<Comision> GetAll()
        {
            List<Comision> comisiones = new List<Comision>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones", sqlConn);
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                while (drComisiones.Read())
                {
                    Comision com = new Comision();
                    com.ID = (int)drComisiones["id_comision"];
                    com.IdPlan = (int)drComisiones["id_plan"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                    comisiones.Add(com);
                }
                drComisiones.Close();
                return comisiones;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Business.Entities.Comision GetOne(int ID)
        {
            Comision com = new Comision();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("select * from comisiones where id_comision=@id", sqlConn);
                cmdComisiones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drComisiones = cmdComisiones.ExecuteReader();
                if (drComisiones.Read())
                {
                    com.ID = (int)drComisiones["id_comision"];
                    com.IdPlan = (int)drComisiones["id_plan"];
                    com.Descripcion = (string)drComisiones["desc_comision"];
                    com.AnioEspecialidad = (int)drComisiones["anio_especialidad"];
                }
                drComisiones.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Comisiones", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return com;
        }

        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();
                //creame la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete = new SqlCommand("delete comisiones where id_comision=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar comision", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Comision comision)
        {
            if (comision.State == BusinessEntity.States.Deleted)
            {
                this.Delete(comision.ID);
            }
            else if (comision.State == BusinessEntity.States.New)
            {
                this.Insert(comision);
            }
            else if (comision.State == BusinessEntity.States.Modified)
            {
                this.Update(comision);
            }
            comision.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Comision comis)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE comisiones SET desc_comision = @desc_comision, " +
                    "id_plan = @id_plan, anio_especialidad = @anio_especialidad " +
                    "WHERE id_comision=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = comis.ID;
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar).Value = comis.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.Int, 50).Value = comis.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int, 50).Value = comis.IdPlan;
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

        protected void Insert(Comision com)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO comisiones(desc_comision,anio_especialidad,id_plan) " +
                    "VALUES(@desc_comision,@anio_especialidad,@id_plan) " +
                    "SELECT @@identity"//esta linea es para recuperar el ID que asignó el sql automaticamente
                    , sqlConn);
                cmdSave.Parameters.Add("@desc_comision", SqlDbType.VarChar, 50).Value = com.Descripcion;
                cmdSave.Parameters.Add("@anio_especialidad", SqlDbType.VarChar, 50).Value = com.AnioEspecialidad;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = com.IdPlan;
                com.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());//asi se obtiene el ID que asigno al BD automaticamente
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear un usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        
    }
}
