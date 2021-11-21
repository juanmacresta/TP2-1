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
    public class AlumnoInscripcionAdapter : Adapter
    {
        public List<AlumnoInscripcion> GetAll()
        {
            List<AlumnoInscripcion> AlumnoInscrip = new List<AlumnoInscripcion>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("select * from alumnos_inscripciones", sqlConn);
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                while (drAlIns.Read())
                {
                    AlumnoInscripcion AI = new AlumnoInscripcion();
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IdAlumno = (int)drAlIns["id_alumno"];
                    AI.IdCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                    AlumnoInscrip.Add(AI);
                }
                drAlIns.Close();
                return AlumnoInscrip;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de Alumnos Inscriptos", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public Business.Entities.AlumnoInscripcion GetOne(int IDA, int IDC)
        {
            AlumnoInscripcion AI = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("select * from alumnos_inscripciones where id_alumno=@id and id_curso=@idc", sqlConn);
                cmdAlIns.Parameters.Add("@id", SqlDbType.Int).Value = IDA;
                cmdAlIns.Parameters.Add("@idc", SqlDbType.Int).Value = IDC;
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                if (drAlIns.Read())
                {
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IdAlumno = (int)drAlIns["id_alumno"];
                    AI.IdCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                }
                drAlIns.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Alumno Inscripto", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return AI;
        }
        public Business.Entities.AlumnoInscripcion GetOne(int ID)
        {
            AlumnoInscripcion AI = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlIns = new SqlCommand("select * from alumnos_inscripciones where id_inscripcion=@id", sqlConn);
                cmdAlIns.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlIns = cmdAlIns.ExecuteReader();
                if (drAlIns.Read())
                {
                    AI.ID = (int)drAlIns["id_inscripcion"];
                    AI.IdAlumno = (int)drAlIns["id_alumno"];
                    AI.IdCurso = (int)drAlIns["id_curso"];
                    AI.Condicion = (string)drAlIns["condicion"];
                    AI.Nota = (int)drAlIns["nota"];
                }
                drAlIns.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar el Alumno Inscripto", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return AI;
        }
        public void Delete(int IDA, int IDC)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones  where id_alumno=@id and id_curso=@idc", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = IDA;
                cmdDelete.Parameters.Add("@idc", SqlDbType.Int).Value = IDC;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar Inscripcion de Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones  where id_inscripcion=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar Inscripcion de Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(AlumnoInscripcion AI)
        {
            if (AI.State == BusinessEntity.States.Deleted)
            {
                this.Delete(AI.IdAlumno, AI.IdCurso);
            }
            else if (AI.State == BusinessEntity.States.New)
            {
                this.Insert(AI);
            }
            else if (AI.State == BusinessEntity.States.Modified)
            {
                this.Update(AI);
            }
            AI.State = BusinessEntity.States.Unmodified;
        }
        protected void Update(AlumnoInscripcion AI)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE alumnos_inscripciones SET  id_alumno=@id_alumno, " +
                    "id_curso = @id_curso, condicion = @condicion, nota = @nota WHERE id_inscripcion = @id_inscripcion" /*id_inscripcion = @id_inscripcion,id_alumno=@id_alumno and id_curso=@id_curso*/, sqlConn);
                cmdSave.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = AI.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = AI.IdAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = AI.IdCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = AI.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = AI.Condicion;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la inscripcion", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(AlumnoInscripcion AI)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("INSERT INTO alumnos_inscripciones(id_alumno,id_curso,nota,condicion) " +
                    "VALUES(@id_alumno,@id_curso,@nota,@condicion) " +
                    "SELECT @@identity"
                    , sqlConn);
                cmdSave.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = AI.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = AI.IdAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = AI.IdCurso;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = AI.Nota;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = AI.Condicion;
                AI.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear una Inscripcion de Alumno", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
