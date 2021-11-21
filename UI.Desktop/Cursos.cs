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
    public partial class Cursos : Form
    {
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        public Cursos(Business.Entities.Personas per)
        {
            InitializeComponent();
            Pe = per;
        }

        public void Listar()
        {
            this.listasCursosTableAdapter.Fill(this.tp2_netDataSet2.ListasCursos);
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet2.ListasCursos' Puede moverla o quitarla según sea necesario.
            this.listasCursosTableAdapter.Fill(this.tp2_netDataSet2.ListasCursos);
            

            this.Listar();
            if (Pe.TiposPersonas == 3)
            {
                this.tsbEditar.Visible = true;
                this.tsbNuevo.Visible = true;
                this.tsbEliminar.Visible = true;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop formCurso = new CursoDesktop(ApplicationForm.ModoForm.Alta);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(this.dgvCurso.SelectedRows[0].Cells[0].Value);
            CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(this.dgvCurso.SelectedRows[0].Cells[0].Value);
            CursoDesktop formCurso = new CursoDesktop(ID, ApplicationForm.ModoForm.Baja);
            formCurso.ShowDialog();
            this.Listar();
        }

        private void dgvCurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
