using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class PersonaDesktop : ApplicationForm
    {
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        public PersonaDesktop()
        {
            InitializeComponent();
            // ApplicationForm app = new ApplicationForm();
        }
        private Regex rx = new Regex(@"^([0-2][0-9]|3[0-1])(\/|-)(0[1-9]|1[0-2])\2(\d{4})$");
        private Business.Entities.Personas _PersonaActual;

        public Business.Entities.Personas PersonaActual
        {
            get { return _PersonaActual; }
            set { _PersonaActual = value; }
        }

        public PersonaDesktop(Business.Entities.Personas per,ModoForm modo) : this()
        {
            this.Modo = modo;
            Pe = per;
        }

        public PersonaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
            
        }
        public PersonaDesktop( int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            PersonasLogic perl = new PersonasLogic();
            PersonaActual = perl.GetOne(ID);
            this.MapearDeDatos();
        }
        

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.PersonaActual.ID.ToString();
            this.txtNombre.Text = this.PersonaActual.Nombre;
            this.txtApellido.Text = this.PersonaActual.Apellido;
            this.txtDireccion.Text = this.PersonaActual.Direccion;
            this.txtEmail.Text = this.PersonaActual.Email;
            this.txtTelefono.Text = this.PersonaActual.Telefono;
            this.txtLegajo.Text = this.PersonaActual.Legajo.ToString();
            this.txtFechaNacimiento.Text = this.PersonaActual.FechaNacimiento.ToString("dd/MM/yyyy");
            
            this.cbPlanes.SelectedValue = this.PersonaActual.IdPlan.ToString();
            this.cbTP.SelectedIndex = this.PersonaActual.TiposPersonas - 1;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                default:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
            }
        }

        public override void MapearADatos()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Business.Entities.Personas per = new Business.Entities.Personas();
                        PersonaActual = per;
                        this.PersonaActual.Apellido = this.txtApellido.Text;
                        this.PersonaActual.Nombre = this.txtNombre.Text;
                        this.PersonaActual.Direccion = this.txtDireccion.Text;
                        this.PersonaActual.Email = this.txtEmail.Text;
                        this.PersonaActual.FechaNacimiento = DateTime.ParseExact(this.txtFechaNacimiento.Text, "dd/MM/yyyy", provider);
                        this.PersonaActual.IdPlan = int.Parse(this.cbPlanes.SelectedValue.ToString());
                        this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.PersonaActual.TiposPersonas = this.cbTP.SelectedIndex + 1;
                        this.PersonaActual.Telefono = txtTelefono.Text;
                        PersonaActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.PersonaActual.ID = int.Parse(this.txtID.Text);
                        this.PersonaActual.Apellido = this.txtApellido.Text;
                        this.PersonaActual.Nombre = this.txtNombre.Text;
                        this.PersonaActual.Direccion = this.txtDireccion.Text;
                        this.PersonaActual.Email = this.txtEmail.Text;
                        this.PersonaActual.FechaNacimiento = DateTime.ParseExact(this.txtFechaNacimiento.Text, "dd/MM/yyyy", provider);
                        this.PersonaActual.IdPlan = int.Parse(this.cbPlanes.SelectedValue.ToString());
                        this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.PersonaActual.TiposPersonas = this.cbTP.SelectedIndex + 1;
                        this.PersonaActual.Telefono = txtTelefono.Text;
                        PersonaActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.PersonaActual.ID = int.Parse(this.txtID.Text);
                        this.PersonaActual.Apellido = this.txtApellido.Text;
                        this.PersonaActual.Nombre = this.txtNombre.Text;
                        this.PersonaActual.Direccion = this.txtDireccion.Text;
                        this.PersonaActual.Email = this.txtEmail.Text;
                        this.PersonaActual.FechaNacimiento = DateTime.ParseExact(this.txtFechaNacimiento.Text, "dd/MM/yyyy", provider);
                        this.PersonaActual.IdPlan = int.Parse(this.cbPlanes.SelectedValue.ToString());
                        this.PersonaActual.Legajo = int.Parse(this.txtLegajo.Text);
                        this.PersonaActual.TiposPersonas = this.cbTP.SelectedIndex + 1;
                        this.PersonaActual.Telefono = txtTelefono.Text;
                        PersonaActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            PersonasLogic usrl = new PersonasLogic();
            usrl.Save(this.PersonaActual);
        }

        public override bool Validar()
        {
            bool resp = false;

            if (this.rx.IsMatch(this.txtFechaNacimiento.Text)) { resp = true; ; }
            else { this.Notificar("Mal formato", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        if (Validar())
                        {
                            this.GuardarCambios();

                            UI.Desktop.UsuarioDesktop usuar = new UI.Desktop.UsuarioDesktop(true, ModoForm.Alta);
                            usuar.ShowDialog();
                            this.Close();
                            
                        }
                        break;

                    }
                case ModoForm.Baja:
                    {
                        if (Validar())
                        {


                            UI.Desktop.UsuarioDesktop usuar = new UI.Desktop.UsuarioDesktop(PersonaActual, ModoForm.Baja);
                            usuar.ShowDialog();
                            this.GuardarCambios();
                            this.Close();
                            
                        }
                        break;


                    }
                default:
                {
                        this.GuardarCambios();
                        this.Close();
                        break;
                    }
            }

        }
        public int dev()
        {
            if (this.PersonaActual != null)
            {
                return this.PersonaActual.TiposPersonas;
            }
            else { return 0; }

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonaDesktop_Load(object sender, EventArgs e)
        {
            PlanLogic plan = new PlanLogic();
            cbPlanes.DataSource = plan.GetAll();
            cbPlanes.DisplayMember = "Descripcion";
            cbPlanes.ValueMember = "id";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdplan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
