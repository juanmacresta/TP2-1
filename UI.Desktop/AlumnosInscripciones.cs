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
    public partial class AlumnosInscripciones : Form
    {
        private Business.Logic.AlumnoInscripcionLogic _AI;
        private Business.Entities.Personas _P;
        public Business.Entities.Personas P { get => _P; set => _P = value; }
        public AlumnosInscripciones(Business.Entities.Personas per)
        {
            InitializeComponent();
            P = per;

        }
        
        public void listar()
        {
            this.listasAlumnosInscripcionTableAdapter.Fill(this.tp2_netDataSet3.ListasAlumnosInscripcion);
        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            this.listar();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AlumnosInscripciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet3.ListasAlumnosInscripcion' Puede moverla o quitarla según sea necesario.
            this.listasAlumnosInscripcionTableAdapter.Fill(this.tp2_netDataSet3.ListasAlumnosInscripcion);
            this.listar();
            switch (P.TiposPersonas)
            {
                case 1:
                    this.tsbEditar.Visible = false;
                    
                    break;
                case 2:
                    this.tsbNuevo.Visible = false;
                    this.tsbEliminar.Visible = false;
                    break;
                
                default:
                    break;
            }

        }
        

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int IDA = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IdAlumno;
            int IDC = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IdCurso;
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(IDA, IDC, ApplicationForm.ModoForm.Modificacion);
            aid.ShowDialog();
            this.listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int IDA = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IdAlumno;
            int IDC = ((Business.Entities.AlumnoInscripcion)this.dgvAluIns.SelectedRows[0].DataBoundItem).IdCurso;
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(IDA, IDC, ApplicationForm.ModoForm.Baja);
            aid.ShowDialog();
            this.listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(P, ApplicationForm.ModoForm.Alta);
            aid.ShowDialog();
            this.listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int IDA = Convert.ToInt32(this.dgvAluIns.SelectedRows[0].Cells[1].Value);
            int IDC = Convert.ToInt32(this.dgvAluIns.SelectedRows[0].Cells[4].Value);
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(IDA, IDC, ApplicationForm.ModoForm.Modificacion);
            aid.ShowDialog();
            this.listar();
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            int IDA = Convert.ToInt32(this.dgvAluIns.SelectedRows[0].Cells[1].Value);
            int IDC = Convert.ToInt32(this.dgvAluIns.SelectedRows[0].Cells[4].Value);
            AlumnosInscripcionesDesktop aid = new AlumnosInscripcionesDesktop(P,IDA, IDC, ApplicationForm.ModoForm.Baja);
            aid.ShowDialog();
            this.listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.listar();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAluIns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
