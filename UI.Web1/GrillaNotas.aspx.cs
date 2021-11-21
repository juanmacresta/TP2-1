using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Web1
{
    public partial class GrillaNotas : System.Web.UI.Page
    {
        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }
        private AlumnoInscripcionLogic _logic;
        private AlumnoInscripcionLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new AlumnoInscripcionLogic();
                }

                return _logic;
            }
        }
        private AlumnoInscripcion Entity
        {
            get;
            set;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ////Verificarmos que se ejecute lo siguiente solamente cuando lo produce
            ////a este evento el botón Insertar
            //if (e.CommandName.ToLower() == "insertar")
            //{
            //    TextBox cajaTexto;
            //    DropDownList ddlTexto;
            //    string textoActual;
            //   Business.Logic.AlumnoInscripcionLogic AINuevo = new Business.Logic.AlumnoInscripcionLogic();



            //    //Busco el control y se lo asigno a la propiedad correspondiente 
            //    //del objeto Usuario
            //    cajaTexto = (TextBox)GridView1.FooterRow.FindControl("txtNota");
            //    textoActual = cajaTexto.Text;
            //    AINuevo.Nota = textoActual;

            //    //Así hago sucesivamente con el resto de los parámetros
            //    ddlTexto = (DropDownList)GridView1.FooterRow.FindControl("ddlCondicion");
            //    textoActual = ddlTexto.SelectedValue;
            //    AINuevo.Condicion = textoActual;

            //    //Defino una variable del Manager para ejecutar el evento de Insertar
            //    Negocio.ManagerUsuarios manager = new Negocio.ManagerUsuarios();

            //    //Agrego el Nuevo Usuario
            //    manager.AgregarUsuario(usuarioNuevo);

            //    //Actualizo la Grilla
            //    grdUsuarios.DataBind();
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
                this.Entity = new AlumnoInscripcion();
                
                
                this.Entity = this.Logic.GetOne(Convert.ToInt32(e.NewValues[0]));
            this.Entity.State = BusinessEntity.States.Modified;
            this.Entity.Condicion = Convert.ToString(e.NewValues[3]);
            this.Entity.Nota = Convert.ToInt32(e.NewValues[4]);
            
                
                this.Logic.Save(Entity);
          
           
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            this.Entity = new AlumnoInscripcion();


            this.Entity = this.Logic.GetOne(Convert.ToInt32(e.NewValues[0]));
            this.Entity.State = BusinessEntity.States.Modified;
            this.Entity.Condicion = Convert.ToString(e.NewValues[1]);
            this.Entity.Nota = Convert.ToInt32(e.NewValues[2]);


            this.Logic.Save(Entity);
        }
    }
    }
