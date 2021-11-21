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
    public partial class WebForm2 : System.Web.UI.Page
    {
        private AlumnoInscripcion Entity
        {
            get;
            set;
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            this.Entity = new AlumnoInscripcion();


            this.Entity = this.Logic.GetOne(Convert.ToInt32(e.OldValues[0]));
            this.Entity.State = BusinessEntity.States.Modified;
            this.Entity.Condicion = Convert.ToString(e.NewValues[4]);
            this.Entity.Nota = Convert.ToInt32(e.NewValues[5]);


            this.Logic.Save(Entity);
        }
    }
}