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
    public class EspecialidadesAdapter : Adapter
    {
        private static List<Especialidad> _Especialidades;

        private static List<Especialidad> Especialidades
        {
            get
            {
                if (_Especialidades == null)
                {
                    _Especialidades = new List<Especialidad>();
                    Business.Entities.Especialidad espe;
                    espe = new Business.Entities.Especialidad();
                    espe.ID = 1;
                    espe.State = Business.Entities.BusinessEntity.States.Unmodified;
                    espe.Descripcion = "Ingenieria";
                    _Especialidades.Add(espe);

                    espe = new Business.Entities.Especialidad();
                    espe.ID = 2;
                    espe.State = Business.Entities.BusinessEntity.States.Unmodified;
                    espe.Descripcion = "Quimica";
                    _Especialidades.Add(espe);
                }
                return _Especialidades;
            }
        }


        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", sqlConn);
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                while (drEspecialidades.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                    especialidades.Add(esp);
                }
                drEspecialidades.Close();
                return especialidades;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public Business.Entities.Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades where id_especialidad=@id", sqlConn);
                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                if (drEspecialidades.Read())
                {
                    esp.ID = (int)drEspecialidades["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidades["desc_especialidad"];
                }
                drEspecialidades.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Especialidades", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;
        }

        public void Delete(int ID)
        {
            try
            {
                //abrimos la conexion
                this.OpenConnection();
                //creame la sentencia sql y asignamos un valor al parametro
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Especialidad esp)
        {
            if (esp.State == BusinessEntity.States.Deleted)
            {
                this.Delete(esp.ID);
            }
            else if (esp.State == BusinessEntity.States.New)
            {
                this.Insert(esp);
            }
            else if (esp.State == BusinessEntity.States.Modified)
            {
                this.Update(esp);
            }
            esp.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE especialidades SET desc_especialidad = @desc_especialidad " +
                    "WHERE id_especialidad=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = esp.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar).Value = esp.Descripcion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la Especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Especialidad esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO especialidades(desc_especialidad) " +
                    "VALUES(@desc_especialidad) " +
                    "SELECT @@identity"//esta linea es para recuperar el ID que asignó el sql automaticamente
                    , sqlConn);
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = esp.Descripcion;
                esp.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());//asi se obtiene el ID que asigno al BD automaticamente
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
        public bool ExisteEspecialidad(int ID)
        {
            bool resp = false;
            Especialidad espe = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades where id_especialidad=@id", sqlConn);
                cmdEspecialidades.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();
                if (drEspecialidades.Read())
                {
                    resp = true;

                }
                drEspecialidades.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la especialidad", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return resp;
        }
    }
}
