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
    public partial class Mostrar : Form
    {
        private Business.Entities.Personas _P;
        public Business.Entities.Personas P { get => _P; set => _P = value; }
        
        private int _band;
        public int band { get => _band; set => _band = 0; }
        public Mostrar()
        {
            InitializeComponent();
            //Mostrar.linklabe += Logout;
        }
        private void Mostrar_Load(object sender, EventArgs e)
        {
            
                this.Hide();
            
                formLogin appLogin = new formLogin();

                if (appLogin.ShowDialog() != DialogResult.OK)
                {
                    this.Dispose();
                }
                else
                {
                    this.Show();
                    Business.Entities.Personas per = appLogin.Damelo();
                    P = per;
                    switch (per.TiposPersonas)
                    {
                        case 1:
                            this.MostrarUsu();
                            break;
                        case 2:
                            this.MostrarProfesor();
                            break;
                        case 3:
                            this.MostrarSuperAdmin();
                            break;
                        default:
                            break;
                    }

                }
            
            



        }

        //private void Logout(object sender, FormClosedEventArgs e)
        //{
        //    contrasenaTxt.Text = "Password";
        //    contrasenaTxt.UseSystemPasswordChar = false;
        //    nomUsuTxt.Text = "Username";

        //    this.Show();
        //}


        private void MostrarUsu()
        {
            btnComision.Visible = true;
            lblComision.Visible = true;
            btnMateria.Visible = true;
            lblMateria.Visible = true;
            btnPlan.Visible = true;
            lblPlan.Visible = true;
            btnEspecialidad.Visible = true;
            lblEspecialidad.Visible = true;
            btnInscripcion.Visible = true;
            lblIsncripcion.Visible = true;
            btnReporteCur.Visible = true;
            lblRepCur.Visible = true;
            btnCurso.Visible = true;
            lblCurso.Visible = true;
            lblRepPlan.Visible = true;
        }

        private void MostrarProfesor()
        {
            btnComision.Visible = true;
            lblComision.Visible = true;
            btnMateria.Visible = true;
            lblComision.Visible = true;
            btnPlan.Visible = true;
            lblComision.Visible = true;
            btnEspecialidad.Visible = true;
            lblEspecialidad.Visible = true;
            btnCurso.Visible = true;
            lblCurso.Visible = true;
            btnEditNota.Visible = true;
            lblNota.Visible = true;
            btnReporteCur.Visible = true;
            lblRepCur.Visible = true;
            btnReportePlan.Visible = true;
            lblRepPlan.Visible = true;
            lblPlan.Visible = true;
            lblMateria.Visible = true;


        }
        private void MostrarSuperAdmin()
        {
            btnComision.Visible = true;
            lblComision.Visible = true;
            btnMateria.Visible = true;
            lblComision.Visible = true;
            btnPlan.Visible = true;
            lblComision.Visible = true;
            btnEspecialidad.Visible = true;
            lblEspecialidad.Visible = true;
            btnUsuario.Visible = true;
            lblUsuario.Visible = true;
            btnCurso.Visible = true;
            lblCurso.Visible = true;
            btnDc.Visible = true;
            lblDocCur.Visible = true;
            btnPersona.Visible = true;
            lblPersona.Visible = true;
            btnReporteCur.Visible = true;
            lblRepCur.Visible = true;
            btnReportePlan.Visible = true;
            lblRepPlan.Visible = true;
            btnInscripcion.Visible = true;
            lblIsncripcion.Visible = true;
            btnEditNota.Visible = true;
            lblNota.Visible = true;
            lblPlan.Visible = true;
            lblMateria.Visible = true;
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios formUsua = new Usuarios();
            formUsua.ShowDialog();
            this.Show();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personas formPersonas = new Personas(P);
            formPersonas.ShowDialog();
            this.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias formMateria = new Materias(P);
            formMateria.ShowDialog();
            this.Show();
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Especialidades formEspe = new Especialidades(P);
            formEspe.ShowDialog();
            this.Show();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cursos formCurso = new Cursos(P);
            formCurso.ShowDialog();
            this.Show();
        }

        private void btnComision_Click(object sender, EventArgs e)
        {
            this.Hide();
            Comisiones formComision = new Comisiones(P);
            formComision.ShowDialog();
            this.Show();
        }

        private void btnPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Planes planes = new Planes(P);
            planes.ShowDialog();
            this.Show();
        }

        private void btnDc_Click(object sender, EventArgs e)
        {
            this.Hide();
            DocenteCurso dc = new DocenteCurso();
            dc.ShowDialog();
            this.Show();
        }

       
        

       
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void btnEditNota_Click(object sender, EventArgs e)
        {
            this.Hide();
            AlumnosInscripciones ai = new AlumnosInscripciones(P);
            ai.ShowDialog();
            this.Show();
        }

        private void btnInscripcion_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AlumnosInscripciones ai = new AlumnosInscripciones(P);
            ai.ShowDialog();
            this.Show();
        }

        private void btnReporteCur_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Informes.ReporteCurso rc = new frm_Informes.ReporteCurso();
            rc.ShowDialog();
            this.Show();
        }

        private void btnmorir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Informes.ReportePlan rp = new frm_Informes.ReportePlan();
            rp.ShowDialog();
            this.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
