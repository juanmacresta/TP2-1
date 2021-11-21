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
    public partial class Materias : System.Web.UI.Page
    {
        #region Props
        private Materia Entity
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

        private MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new MateriaLogic();
                }

                return _logic;
            }
        }
        private Usuario _Usu;
        public Usuario Usu { get => _Usu; set => _Usu = value; }
        private Business.Entities.Personas _Per;

        public Business.Entities.Personas Per { get => _Per; set => _Per = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Usu = (Usuario)Session["Usuario"];
            PersonasLogic p = new PersonasLogic();
            Per = p.GetOne(Usu.IdPersona);
            switch (Per.TiposPersonas)
            {
                case 1:
                    {

                        break;
                    }
                case 2:
                    {


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
            
            if (!this.IsPostBack)
            {
                this.cargarDDl();
            }
            this.LoadGrid();
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
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.hsSemTextBox.Text = this.Entity.HsSemanales.ToString();
            this.hsTotTextBox.Text = this.Entity.HsTotales.ToString();
            this.ddlPlan.Text = this.Entity.IdPlan.ToString();
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
        private void LoadEntity(Materia materia)
        {
            materia.Descripcion = this.descripcionTextBox.Text;
            materia.HsSemanales = int.Parse(this.hsSemTextBox.Text);
            materia.HsTotales = int.Parse(this.hsTotTextBox.Text);
            materia.IdPlan = int.Parse(this.ddlPlan.SelectedValue);
        }

        private void SaveEntity(Materia materia)
        {
            this.Logic.Save(materia);
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

                        this.Entity = new Materia(); ;
                        this.Entity.ID = this.SelectedID;
                        this.Entity.State = BusinessEntity.States.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        this.LoadGrid();

                        this.formPanel.Visible = false;

                    }
                    break;
                case FormModes.Alta:

                    {

                        this.Entity = new Materia();
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
            this.descripcionTextBox.Enabled = enable;
            this.hsSemTextBox.Enabled = enable;
            this.hsTotTextBox.Enabled = enable;
            this.ddlPlan.Enabled = enable;

        }

        private void ClearForm()
        {
            this.idTextBox.Text = string.Empty;
            this.descripcionTextBox.Text = string.Empty;
            this.hsSemTextBox.Text = string.Empty;
            this.hsTotTextBox.Text = string.Empty;
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
            PlanLogic p = new PlanLogic();
            ddlPlan.DataSource = p.GetAll();
            ddlPlan.DataTextField = "Descripcion";
            ddlPlan.DataValueField = "ID";
            ddlPlan.DataBind();
        }

    }
}