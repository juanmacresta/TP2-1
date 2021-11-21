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
    public partial class Inscripciones : System.Web.UI.Page
    {
        #region Props
        private Usuario _Usu;
        
        public Usuario Usu { get => _Usu; set => _Usu = value; }
        private Business.Entities.Personas _Per;

        public Business.Entities.Personas Per { get => _Per; set => _Per = value; }
        private AlumnoInscripcion Entity
        {
            get;
            set;
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null) { return (int)this.ViewState["SelectedID"]; }
                else { return 0; }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool isEntitySelected
        {
            get { return (this.SelectedID != 0); }
        }



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
        #endregion
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
            this.Usu = (Usuario)Session["Usuario"];
            PersonasLogic p = new PersonasLogic();
            Per = p.GetOne(Usu.IdPersona);
            switch (Per.TiposPersonas)
            {
                case 1:
                    {
                        this.nuevoLinkButton.Visible = true;
                        this.eliminarLinkButton.Visible = true;
                        break;
                    }
                case 2:
                    {
                        
                        this.editarLinkButton.Visible = true;
                        break;
                    }
                case 3:
                    {
                        this.nuevoLinkButton.Visible = true;
                        this.eliminarLinkButton.Visible = true;
                        this.editarLinkButton.Visible = true;
                        break;
                    }
            }
            this.LoadGrid();
            if (!this.IsPostBack)
            {
                this.cargarDDl();
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }

        private void LoadForm(int id)
        {
            this.idTextBox.Enabled = false;
            this.idAlumnotBox.Enabled = false;
            this.idCursoDdl.Enabled = false;
            this.Entity = this.Logic.GetOne(id);
            this.idTextBox.Text = (this.Entity.ID).ToString();
            this.idAlumnotBox.Text = this.Entity.IdAlumno.ToString();
            this.notaTBoc.Text = this.Entity.Nota.ToString();
            this.condicionTBox.Text = this.Entity.Condicion.ToString();
            this.idCursoDdl.Text = this.Entity.IdCurso.ToString();
        }
        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void LoadEntity(AlumnoInscripcion ai)
        {
            
            
            ai.IdAlumno = int.Parse(this.idAlumnotBox.Text);
            ai.Condicion = this.condicionTBox.Text;
            ai.IdCurso = int.Parse(this.idCursoDdl.Text);
            ai.Nota = 0;
        }

        private void SaveEntity(AlumnoInscripcion ai)
        {
            this.Logic.Save(ai);
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {



            switch (this.FormMode)
            {
                case FormModes.Baja:

                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    this.formPanel.Visible = false;

                    break;
                case FormModes.Modificacion:

                    {

                        this.Entity = new AlumnoInscripcion(); ;
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = AlumnoInscripcion.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();

                        this.formPanel.Visible = false;

                    }
                    break;
                case FormModes.Alta:

                    {

                        this.Entity = new AlumnoInscripcion();
                        this.Entity.State = BusinessEntity.States.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();

                        this.formPanel.Visible = false;

                    }
                    break;
                default:
                    break;
            }
        }

        private void EnableForm(bool enable)
        {
            this.idTextBox.Enabled = enable;
            this.idCursoDdl.Enabled = enable;
            this.condicionTBox.Enabled = enable;
            this.idAlumnotBox.Enabled = enable;
            this.notaTBoc.Enabled = enable;


        }

        private void ClearForm()
        {
            this.idTextBox.Text = string.Empty;

            this.idAlumnotBox.Text = string.Empty;
            this.notaTBoc.Text = string.Empty;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;

            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.formPanel.Visible = false;
        }
        private void cargarDDl()
        {
            CursoLogic p = new CursoLogic();
            idCursoDdl.DataSource = p.GetAll();
            idCursoDdl.DataTextField = "ID";
            idCursoDdl.DataValueField = "ID";
            idCursoDdl.DataBind();
        }
    }
}