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
    public partial class Planes : System.Web.UI.Page
    {
        #region Props
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
                this.cargarDD1();
            }
            this.LoadGrid();
        }
        private Business.Entities.Plan Entity
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
        PlanLogic _logic;
        private PlanLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new PlanLogic();
                }

                return _logic;
            }

        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void cargarDD1()
        {
            EspecialidadLogic p = new EspecialidadLogic();
            ddlIDEsp.DataSource = p.GetAll();
            ddlIDEsp.DataTextField = "Descripcion";
            ddlIDEsp.DataValueField = "id";
            ddlIDEsp.DataBind();
        }

        private void LoadForm(int ID)
        {
            this.Entity = this.Logic.GetOne(ID);
            this.DescripcionTextBox.Text = this.Entity.Descripcion;
            ddlIDEsp.DataValueField = this.Entity.IdEspecialidad.ToString();
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
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


        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadEntity(Business.Entities.Plan plan)
        {
            plan.Descripcion = this.DescripcionTextBox.Text;
            plan.IdEspecialidad = int.Parse(this.ddlIDEsp.SelectedValue.ToString());
        }

        private void SaveEntity(Business.Entities.Plan plan)
        {
            this.Logic.Save(plan);
        }




        private void EnableForm(bool enable)
        {
            this.DescripcionTextBox.Enabled = enable;
            this.ddlIDEsp.Enabled = enable;
        }

        private void ClearForm()
        {
            this.DescripcionTextBox.Text = string.Empty;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
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


                    this.Entity = new Business.Entities.Plan();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();

                    this.formPanel.Visible = false;


                    break;
                case FormModes.Alta:
                    this.Entity = new Business.Entities.Plan();
                    this.Entity.State = BusinessEntity.States.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;


                    break;
                default:
                    break;
            }
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
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
    }
}