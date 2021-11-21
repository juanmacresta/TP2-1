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
    public partial class NotasGrilla : System.Web.UI.Page
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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            //this.Entity = new AlumnoInscripcion();


            //this.Entity = this.Logic.GetOne(Convert.ToInt32(e.NewValues[0]));
            //this.Entity.State = BusinessEntity.States.Modified;
            //this.Entity.Condicion = Convert.ToString(e.NewValues[4]);
            //this.Entity.Nota = Convert.ToInt32(e.NewValues[5]);


            //this.Logic.Save(Entity);
        }

        protected void GridView1_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {
            this.Entity = new AlumnoInscripcion();


            this.Entity = this.Logic.GetOne(Convert.ToInt32(e.NewValues[0]));
            this.Entity.State = BusinessEntity.States.Modified;
            this.Entity.Condicion = Convert.ToString(e.NewValues[5]);
            this.Entity.Nota = Convert.ToInt32(e.NewValues[6]);


            this.Logic.Save(Entity);
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //switch(ddl)

            //Select Case ddlBuscar.SelectedValue
            //Case 1
            //    SqlDataSource1.FilterExpression = "Codigo = {0}"
            //Case 2
            //    SqlDataSource1.FilterExpression = "Nombre like '%{0}%'"
            //End Select
            //SqlDataSource1.FilterParameters(0).DefaultValue = txtBuscar.Text
        }

        protected void ddlBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}