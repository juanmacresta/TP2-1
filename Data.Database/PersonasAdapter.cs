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
    public class PersonasAdapter : Adapter
    {
        private static List<Personas> _Personas;

        private static List<Personas> Persona
        {
            get
            {
                if (_Personas == null)
                {
                    _Personas = new List<Personas>();
                    Business.Entities.Personas per;
                    per = new Business.Entities.Personas();
                    per.ID = 1;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Sabrina";
                    per.Apellido = "Vazquez";
                    per.Direccion = "Pasco 5568";
                    per.Email = "Sabrina@gmail.com";
                    per.FechaNacimiento = new DateTime(1995, 05, 19);
                    per.IdPlan = 15;
                    per.Legajo = 46967;
                    per.Telefono = "4234507";
                    _Personas.Add(per);

                    per = new Business.Entities.Personas();
                    per.ID = 2;
                    per.State = Business.Entities.BusinessEntity.States.Unmodified;
                    per.Nombre = "Marlen";
                    per.Apellido = "Vazquez";
                    per.Direccion = "Linir 1245";
                    per.Email = "mar@gmail.com";
                    per.FechaNacimiento = new DateTime(1996, 04, 17);
                    per.IdPlan = 10;
                    per.Legajo = 45874;
                    per.Telefono = "4234507";
                    _Personas.Add(per);
                }
                return _Personas; 
            }
        }
        public List<Personas> GetAllP()
        {
            List<Personas> Personas = new List<Personas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where tipo_persona=2", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Personas per = new Personas();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TiposPersonas = (int)drPersonas["tipo_persona"];
                    per.IdPlan = (int)drPersonas["id_plan"];
                    Personas.Add(per);
                }
                drPersonas.Close();
                return Personas;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de profesores", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Personas> GetAllA()
        {
            List<Personas> Personas = new List<Personas>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where tipo_persona=1", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                while (drPersonas.Read())
                {
                    Personas per = new Personas();
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TiposPersonas = (int)drPersonas["tipo_persona"];
                    per.IdPlan = (int)drPersonas["id_plan"];
                    Personas.Add(per);
                }
                drPersonas.Close();
                return Personas;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de profesores", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public List<Personas> GetAll()
        {
            return new List<Personas>(Persona);
        }

        public Personas GetOne(int ID)
        {
            Personas per = new Personas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where id_persona=@id", sqlConn);
                cmdPersonas.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TiposPersonas = (int)drPersonas["tipo_persona"];
                    per.IdPlan = (int)drPersonas["id_plan"];
                }
                drPersonas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save (Personas pers)
        {
            if (pers.State == BusinessEntity.States.Deleted)
            {
                this.Delete(pers.ID);
            }
            else if (pers.State == BusinessEntity.States.New)
            {
                this.Insert(pers);
            }
            else if (pers.State == BusinessEntity.States.Modified)
            {
                this.Update(pers);
            }
            pers.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(Personas persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE personas SET apellido = @apellido, nombre=@nombre, " +
                    "direccion = @direccion, email = @email, telefono = @telefono, fecha_nac = @fecha_nac , legajo=@legajo, tipo_persona=@tipo_persona,id_plan=@id_plan " +
                    "WHERE id_persona=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TiposPersonas;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IdPlan;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Personas persona)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO personas(nombre,apellido,direccion,email,telefono,fecha_nac,legajo,tipo_persona,id_plan) " +
                    "VALUES(@nombre,@apellido,@direccion,@email,@telefono,@fecha_nac,@legajo,@tipo_persona,@id_plan) " +
                    "SELECT @@identity"
                    , sqlConn);
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = persona.TiposPersonas;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IdPlan;
                persona.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear una persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Business.Entities.Personas Ult()
        {
            Personas per = new Personas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("select * from personas where id_persona=(select max(id_persona) From personas)", sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();
                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.Telefono = (string)drPersonas["telefono"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.TiposPersonas = (int)drPersonas["tipo_persona"];
                    per.IdPlan = (int)drPersonas["id_plan"];
                }
                drPersonas.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return per;
        }
    }
}
