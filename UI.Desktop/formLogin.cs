using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        private Usuario _u;

        public Usuario U { get => _u; set => _u = value; }
        private void ingresarBtn_Click(object sender, EventArgs e)
        {
            U = new Usuario();
            U.NombreUsuario = nomUsuTxt.Text;
            U.Clave = contrasenaTxt.Text;
            UsuarioLogic u2 = new UsuarioLogic();
            if (u2.GetOne(U.NombreUsuario, U.Clave))
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente."
                    , "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                U = u2.FindOne(U.NombreUsuario, U.Clave);
                
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public Business.Entities.Personas Damelo()
        {
            PersonasLogic per = new PersonasLogic();
            return per.GetOne(U.IdPersona);
        }
        private void formLogin_Load(object sender, EventArgs e)
        {
            contrasenaTxt.UseSystemPasswordChar = true;

        }

        
    }
}
