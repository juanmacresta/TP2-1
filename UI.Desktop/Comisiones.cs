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
    public partial class Comisiones : Form
    {
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        public Comisiones(Business.Entities.Personas per)
        {
            InitializeComponent();
            Pe = per;
        }

        public void Listar()
        {
            ComisionLogic ul = new ComisionLogic();
            this.dgvComision.DataSource = ul.GetAll();
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            this.dgvComision.AutoGenerateColumns = false;
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
            ComisionDesktop formComision = new ComisionDesktop(ApplicationForm.ModoForm.Alta);
            formComision.ShowDialog();
            this.Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Comision)this.dgvComision.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop formComision = new ComisionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
            formComision.ShowDialog();
            this.Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int ID = ((Business.Entities.Comision)this.dgvComision.SelectedRows[0].DataBoundItem).ID;
            ComisionDesktop formComision = new ComisionDesktop(ID, ApplicationForm.ModoForm.Baja);
            formComision.ShowDialog();
            this.Listar();
        }

        private void dgvComision_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
