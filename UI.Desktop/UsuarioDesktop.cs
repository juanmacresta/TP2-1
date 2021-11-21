using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        public UsuarioDesktop()
        {
            InitializeComponent();
            // ApplicationForm app = new ApplicationForm();
        }
        private bool msj1 = false;
        private int _tp;
        public int Tp { get => _tp; set => _tp = value; }

        private Usuario _UsuarioActual;
        private Usuario _UsuarioActual1;
        public Usuario UsuarioActual1
        {
            get { return _UsuarioActual1; }
            set { _UsuarioActual1 = value; }
        }
        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
            set { _UsuarioActual = value; }
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }
        public UsuarioDesktop(Business.Entities.Personas per, ModoForm modo) : this()
        {
            this.Modo = modo;

            this.txtID.Enabled = true;
            Pe = per;
            UsuarioLogic usu= new UsuarioLogic();
            UsuarioActual = usu.GetOneP(Pe.ID);
            this.txtID.Text = UsuarioActual.ID.ToString();
            this.txtNombre.Text = Pe.Nombre;
            this.txtApellido.Text = Pe.Apellido;
            this.txtEmail.Text = Pe.Email;
            this.txtNombre.Enabled = false;
            this.txtApellido.Enabled = false;
            this.txtEmail.Enabled = false;
            Tp = Pe.ID;
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            UsuarioLogic usrl = new UsuarioLogic();
            UsuarioActual = usrl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos() 
        {
            this.txtID.Text = this.UsuarioActual.ID.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

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
                //default:
                //    {
                //        this.btnAceptar.Text = "Aceptar";
                //        break;
                //    }
            }
        }
        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Usuario usr = new Usuario();
                        UsuarioActual = usr;
                        if (msj1)
                        {

                            this.UsuarioActual.Nombre = this.txtNombre.Text;
                            this.UsuarioActual.Apellido = this.txtApellido.Text;
                            this.UsuarioActual.Email = this.txtEmail.Text;
                            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                            this.UsuarioActual.Clave = this.txtClave.Text;
                            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                            this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                            this.UsuarioActual.IdPersona = Tp;
                            UsuarioActual.State = BusinessEntity.States.New;

                        }
                        else
                        {
                            this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                            this.UsuarioActual.Nombre = this.txtNombre.Text;
                            this.UsuarioActual.Apellido = this.txtApellido.Text;
                            this.UsuarioActual.Clave = this.txtClave.Text;
                            this.UsuarioActual.Email = this.txtEmail.Text;
                            this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                            this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                            UsuarioActual.State = BusinessEntity.States.New;
                        }
                        break;

                    }
                case ModoForm.Modificacion:
                    {
                        this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Nombre = this.txtNombre.Text;
                        this.UsuarioActual.Apellido = this.txtApellido.Text;
                        this.UsuarioActual.Clave = this.txtClave.Text;
                        this.UsuarioActual.Email = this.txtEmail.Text;
                        this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                        UsuarioActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.UsuarioActual.ID = int.Parse(this.txtID.Text);
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Nombre = this.txtNombre.Text;
                        this.UsuarioActual.Apellido = this.txtApellido.Text;
                        this.UsuarioActual.Clave = this.txtClave.Text;
                        this.UsuarioActual.Email = this.txtEmail.Text;
                        this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                        this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
                        UsuarioActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }
        }
        public UsuarioDesktop(bool msj, ModoForm modo) : this()
        {
            this.Modo = modo;
            if (msj)
            {
                PersonasLogic per = new PersonasLogic();
                Business.Entities.Personas person = per.Ult();
                this.txtNombre.Text = person.Nombre;
                this.txtApellido.Text = person.Apellido;
                this.txtEmail.Text = person.Email;
                this.txtNombre.Enabled = false;
                this.txtApellido.Enabled = false;
                this.txtEmail.Enabled = false;
                Tp = person.ID;
            }
            this.msj1 = msj;
        }
        public override void GuardarCambios() 
        {
            MapearADatos();
            UsuarioLogic usrl = new UsuarioLogic();
            usrl.Save(this.UsuarioActual);
        }

        public override bool Validar() 
        {
            bool resp = false;
            string rta;
            if (!("".Equals(txtNombre.Text)))
            {
                if (!("".Equals(txtApellido.Text)))
                {
                    if (!("".Equals(txtEmail.Text)))
                    {
                        if (!("".Equals(txtUsuario.Text)))
                        {
                            if (txtClave.Text.Equals(txtConfirmarClave.Text) && txtClave.Text.Length >= 8)
                            {
                                resp = true;
                            }
                            else { { rta = "Las contraseñas no coinciden o tiene menos de 8 letras"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                        }
                        else { { rta = "El usuario no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                    }
                    else { { rta = "El Email no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                }
                else { { rta = "El apellido no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            }
            else { { rta = "El nombre no puede ser vacio"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
