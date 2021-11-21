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
    public partial class DocentesCursos : System.Web.UI.Page
    {
        #region Props
        private DocenteCurso Entity
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
        private DocenteCursoLogic _logic;
        private DocenteCursoLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new DocenteCursoLogic();
                }

                return _logic;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
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
            this.Entity = this.Logic.GetOne(id);
            this.idTextBox.Text = (this.Entity.ID).ToString();
            this.IdDocente.Text = this.Entity.IdDocente.ToString();
            this.CargotBox.Text = this.Entity.Cargo.ToString();
            this.IdCursoDL.Text = this.Entity.IdCurso.ToString();
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
        private void LoadEntity(DocenteCurso dc)
        {
            
            dc.IdDocente = int.Parse(this.IdDocente.Text);
            dc.Cargo = int.Parse(this.CargotBox.Text);
            dc.IdCurso = int.Parse(this.IdCursoDL.Text);
        }

        private void SaveEntity(DocenteCurso dc)
        {
            this.Logic.Save(dc);
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

                        this.Entity = new DocenteCurso(); ;
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = DocenteCurso.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();

                        this.formPanel.Visible = false;

                    }
                    break;
                case FormModes.Alta:

                    {

                        this.Entity = new DocenteCurso();
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
            this.IdCursoDL.Enabled = enable;
            this.IdDocente.Enabled = enable;
            this.CargotBox.Enabled = enable;
            

        }

        private void ClearForm()
        {
            this.idTextBox.Text = string.Empty;
            
            this.IdDocente.Text = string.Empty;
            this.CargotBox.Text = string.Empty;
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
            IdCursoDL.DataSource = p.GetAll();
            IdCursoDL.DataTextField = "ID";
            IdCursoDL.DataValueField = "ID";
            IdCursoDL.DataBind();
        }
    }
}