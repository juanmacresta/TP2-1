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
    public partial class _Default : Page
    {
        private Usuario _Usu;
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
        public Usuario Usu { get => _Usu; set => _Usu = value; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                this.verificarSession();
                this.Usu = (Usuario)Session["Usuario"];
                Label1.Text = "Bienvenido: " + Usu.Nombre + " " + Usu.Apellido;
                Business.Logic.PersonasLogic per = new Business.Logic.PersonasLogic();
                
                
                switch((per.GetOne(Usu.IdPersona)).TiposPersonas)
                {
                    case 1:
                        {
                            MostrarUsu();
                            break;
                        }
                        
                    case 2:
                        {
                            MostrarProf();
                            break;
                        }
                    case 3:
                        {
                            MostrarSuper();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
        private void MostrarUsu()
        {
            btnComision.Visible = true;
            btnMateria.Visible = true;
            btnPlan.Visible = true;
            btnEspecialidad.Visible = true;
            btnInscripcion.Visible = true;
            btnRepCur.Visible = true;
            btnCurso.Visible = true;
        }
        private void MostrarProf()
        {
            btnComision.Visible = true;
            btnMateria.Visible = true;
            btnPlan.Visible = true;
            btnEspecialidad.Visible = true;
            btnCurso.Visible = true;
            btnRepCur.Visible = true;
            btnEditar.Visible = true;
        }
        private void MostrarSuper()
        {
            btnComision.Visible = true;
            btnMateria.Visible = true;
            btnPlan.Visible = true;
            btnEspecialidad.Visible = true;
            btnUsuario.Visible = true;
            btnCurso.Visible = true;
            btnDocenteCurso.Visible = true;
            btnPersona.Visible = true;
            btnRepCur.Visible = true;
            btnRepPlan.Visible = true;
            btnInscripcion.Visible = true;
            btnEditar.Visible = true;
        }
        private void verificarSession()
        {
            if (Session["Usuario"] == null)
            {
                Response.Redirect("~/Login");
            }
        }


        protected void btnPersona_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Personas");
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Usuarios");
        }

        protected void btnCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Cursos");
        }

        protected void btnComision_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Comisiones");
        }

        protected void btnPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Planes");
        }

        protected void btnEspecialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Especialidades");
        }

        protected void btnMateria_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Materias");
        }

        protected void btnDocenteCurso_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DocentesCursos");
        }

        protected void btnInscripcion_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inscripciones");
        }

        protected void btnRepCur_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/form_Informes/InformesCursos");
        }

        protected void btnRepPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/form_Informes/InformesPlanes");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/NotasGrilla");
        }
    }
}