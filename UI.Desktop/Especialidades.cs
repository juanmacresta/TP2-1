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
    public partial class Especialidades : Form
    {
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        public Especialidades(Business.Entities.Personas per)
        {
            InitializeComponent();
            Pe = per;
        }

        public void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            this.dgvEspecialidades.DataSource = el.GetAll();
        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            this.dgvEspecialidades.AutoGenerateColumns = false;
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
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).ID;
            EspecialidadDesktop formEspecialidad = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Baja);
            formEspecialidad.ShowDialog();
            this.Listar();
        }

        private void tcEspecialidades_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
