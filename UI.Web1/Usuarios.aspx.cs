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
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region Props
        private int op = 0;
        private Business.Entities.Usuario Entity
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
        private Business.Entities.Personas p;

        PersonasLogic _pLogic;
        private PersonasLogic PLogic
        {
            get
            {

                if (_pLogic == null)
                {
                    _pLogic = new PersonasLogic();
                }

                return _pLogic;
            }

        }
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {

                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }

                return _logic;
            }

        }

        public Business.Entities.Personas P { get => p; set => p = value; }
        string q;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ClearForm();
            this.LoadGrid();
            if (Session["Vuelta"] != null) { q = (string)Session["Vuelta"]; }

            if (q != null)
            {
                Response.Clear();
                this.Panel_1.Visible = true;
                this.ClearForm();
                op = 1;
                P = PLogic.Ult();
                this.nuevoLinkButton_Click(sender, e);
            }
            Business.Entities.Personas m = (Business.Entities.Personas)Session["Persona"];
            if (!IsPostBack)
            {
                Session["Usu"] = null;
            }
            else if (IsPostBack)
            {
                this.ClearForm();
                this.LoadGrid();
            }

            if (Session["Usu"] != null)
            {
                this.EnableForm(true);
                Entity = (Usuario)Session["Usu"];
            }
        }

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.txtNU.Text = this.Entity.NombreUsuario;
        }

        protected void gridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
            this.LoadForm(this.SelectedID);
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
                this.EnableForm(true);
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificacion;
                this.LoadForm(this.SelectedID);
            }
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        private void LoadEntity(Usuario usuario)
        {

            usuario.Clave = this.claveTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            if (op == 0)
            {
                usuario.NombreUsuario = this.txtNU.Text;
                usuario.Nombre = this.nombreTextBox.Text;
                usuario.Apellido = this.apellidoTextBox.Text;
                usuario.Email = this.emailTextBox.Text;
                usuario.IdPersona = int.Parse(this.txtIdPersona.Text);
            }
            else
            {
                string s = (string)Session["Vuelta"];
                usuario.NombreUsuario = s;
                this.txtIdPersona.Visible = false;
                usuario.Nombre = P.Nombre;
                usuario.Apellido = P.Apellido;
                usuario.Email = P.Email;
                usuario.IdPersona = P.ID;
            }
        }
        /*private void LoadEntityAlt(Usuario usuario)
        {
            usuario.NombreUsuario = this.txtNU.Text;
            usuario.Clave = this.claveTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
        }*/

        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
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

                    this.Entity = new Usuario();
                    this.Entity.ID = this.SelectedID;
                    this.Entity.State = BusinessEntity.States.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;
                    break;
                case FormModes.Alta:

                    this.Entity = new Usuario();
                    this.Entity.State = BusinessEntity.States.New;
                    /* if (op == 0)
                     {*/
                    this.LoadEntity(this.Entity);
                    /*}
                    else { this.LoadEntityAlt(this.Entity); }*/

                    this.SaveEntity(this.Entity);
                    this.LoadGrid();
                    this.formPanel.Visible = false;

                    break;
                default:
                    break;
            }
        }


        private void EnableForm(bool enable)
        {
            this.nombreTextBox.Enabled = enable;
            this.apellidoTextBox.Enabled = enable;
            this.emailTextBox.Enabled = enable;
            this.claveTextBox.Visible = enable;
            this.claveLabel.Visible = enable;
            this.repetirClaveLabel.Visible = enable;
            this.repetirClaveTextBox.Visible = enable;
            if (op == 0)
            {
                this.nombreUsuarioLabel.Visible = enable;
                this.txtNU.Enabled = enable;
                txtNU.Visible = enable;
            }
        }

        private void ClearForm()
        {
            this.nombreTextBox.Text = string.Empty;
            this.apellidoTextBox.Text = string.Empty;
            this.emailTextBox.Text = string.Empty;
            this.habilitadoCheckBox.Checked = false;
            this.txtNU.Text = string.Empty;
        }

        protected void nuevoLinkButton_Click(object sender, EventArgs e)
        {

            this.formPanel.Visible = true;
            this.FormMode = FormModes.Alta;
            this.ClearForm();
            this.EnableForm(true);
            if (op == 1) { this.cargatxt(); }
        }

        private void cargatxt()
        {
            txtNU.Text = (string)Session["Vuelta"];
            nombreTextBox.Text = P.Nombre;
            apellidoTextBox.Text = P.Apellido;
            emailTextBox.Text = P.Email;
        }

        protected void cancelarLinkButton_Click(object sender, EventArgs e)
        {
            this.formPanel.Visible = false;
        }


        protected void txtBuscCla_TextChanged1(object sender, EventArgs e)
        {

        }


        protected void repetirClaveTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtNU_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default");
        }

        /*protected void LinkButtonBuscar_Click(object sender, EventArgs e)
        {
            Session["Usu"] = Logic.FindOne(txtBusN.Text);
            Entity = (Usuario)Session["Usu"];
            if (Entity != null)
            {
                this.formPanel.Visible = true;
                // this.FormMode = FormModes.Modificacion;
                this.LoadForm(Entity.ID);
            }
        }*/
    }
}