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
    public partial class DocenteCurso : Form
    {
        private Business.Logic.DocenteCursoLogic dc;
        public DocenteCurso()
        {
            InitializeComponent();
        }

        private void DocenteCurso_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet4.ListasDocentesCursos' Puede moverla o quitarla según sea necesario.
            this.listasDocentesCursosTableAdapter.Fill(this.tp2_netDataSet4.ListasDocentesCursos);
            listar();
        }
        public void listar()
        {
            this.listasDocentesCursosTableAdapter.Fill(this.tp2_netDataSet4.ListasDocentesCursos);
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            DocenteCursosDesktop dcd = new DocenteCursosDesktop(ApplicationForm.ModoForm.Alta);
            dcd.ShowDialog();
            this.listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvDocCur.SelectedRows[0].Cells[0].Value);
            DocenteCursosDesktop dcd = new DocenteCursosDesktop(id, ApplicationForm.ModoForm.Modificacion);
            dcd.ShowDialog();
            this.listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dgvDocCur.SelectedRows[0].Cells[0].Value);
            DocenteCursosDesktop dcd = new DocenteCursosDesktop(id, ApplicationForm.ModoForm.Baja);
            dcd.ShowDialog();
            this.listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
