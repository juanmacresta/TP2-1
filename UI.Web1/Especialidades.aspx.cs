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
    public partial class Especialidades : System.Web.UI.Page
    {

        private Especialidad Entity
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
        private EspecialidadLogic _logic;
        private EspecialidadLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new EspecialidadLogic();
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
            this.LoadGrid();
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        protected void aceptarLinkButton_Click(object sender, EventArgs e)
        {
            this.formActionsPanel.Visible = true;
            switch (this.FormMode)
            {
                case FormModes.Baja:

                    this.DeleteEntity(this.SelectedID);
                    this.LoadGrid();
                    this.formPanel.Visible = false;

                    break;
                case FormModes.Modificacion:

                    {

                        this.Entity = new Especialidad(); ;
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

                        this.Entity = new Especialidad();
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

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.ClearForm();
            this.formPanel.Visible = false;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formActionsPanel.Visible = true;
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }

        protected void eliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.isEntitySelected)
            {
                this.formActionsPanel.Visible = true;
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Baja;
                this.EnableForm(false);
                this.LoadForm(this.SelectedID);
            }
        }

        private void EnableForm(bool enable)
        {
            this.txtID.Enabled = enable;
            this.txtDesc.Enabled = enable;
        }
        private void ClearForm()
        {
            this.txtID.Text = string.Empty;
            this.txtDesc.Text = string.Empty;
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        private void SaveEntity(Especialidad esp)
        {
            this.Logic.Save(esp);
        }
        private void LoadEntity(Especialidad esp)
        {
            esp.Descripcion = this.txtDesc.Text;

        }
        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.txtID.Text = (this.Entity.ID).ToString();
            this.txtDesc.Text = this.Entity.Descripcion;
        }
    }
}