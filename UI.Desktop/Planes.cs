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
    public partial class Planes : Form
    {
        private Business.Logic.PlanLogic p1;
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        public Planes(Business.Entities.Personas per)
        {
            InitializeComponent();
            Pe = per;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
            if (Pe.TiposPersonas==3)
            {
                this.tsbEditar.Visible = true;
                this.tsbNuevo.Visible = true;
                this.tsbEliminar.Visible = true;
            }
           
                    
                    
               
           
        }
        public void Listar()
        {
            this.dgvPlanes.AutoGenerateColumns = false;
            this.p1 = new PlanLogic();
            this.dgvPlanes.DataSource = p1.GetAll();
        }
        
        private void tsbNuevo_Click(object sender, EventArgs e)
        {

        }
        private void tsbEditar_Click(object sender, EventArgs e)
        {

        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {

        }

        
        private void tsbReporte_Click(object sender, EventArgs e)
        {
            //ReportePlanes r = new ReportePlanes();
            //r.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            PlanDesktop plan = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            plan.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop plan = new PlanDesktop(id, ApplicationForm.ModoForm.Modificacion);
            plan.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).ID;
            PlanDesktop plan = new PlanDesktop(id, ApplicationForm.ModoForm.Baja);
            plan.ShowDialog();
            this.Listar();
        }
    }
}
