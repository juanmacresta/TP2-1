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
    public partial class Login : System.Web.UI.Page
    {
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario usu = Logic.FindOne(txtUsu.Text, txtContra.Text);
            if (usu.IdPersona != 0)
            {
                int id = usu.ID;
                Session["Usuario"] = usu;
                Response.Write("<script> alert(" + "'Hola'" + ") </script>");
                Response.Redirect("~/Default");

            }
            else { Response.Write("<script> alert(" + "'Datos incorrectos'" + ") </script>"); }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}