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
    public partial class Personas : Form
    {
        private Business.Entities.Personas _Pe;
        public Business.Entities.Personas Pe { get => _Pe; set => _Pe = value; }
        private Business.Logic.PersonasLogic u1;
        public Personas(Business.Entities.Personas per)
        {
            InitializeComponent();
            Pe = per;
        }

        public void Listar()
        {
            cbEleccion.Items.Add("Alumnos");
            cbEleccion.Items.Add("Profesores");
            //cbEleccion.SelectedIndex = 1;
            if (cbEleccion.SelectedIndex == 1)
            {
                this.ListarP();

            }
            else { this.ListarA(); }
        }
        public void ListarA()
        {
            this.dgvPersonas.AutoGenerateColumns = false;
            this.u1 = new Business.Logic.PersonasLogic();
            this.dgvPersonas.DataSource = u1.GetAllA();
        }
        public void ListarP()
        {
            this.dgvPersonas.AutoGenerateColumns = false;
            this.u1 = new Business.Logic.PersonasLogic();
            this.dgvPersonas.DataSource = u1.GetAllP();
        }
        private void Personas_Load(object sender, EventArgs e)
        {
            cbEleccion.Items.Add("Alumnos");
            cbEleccion.Items.Add("Profesores");
            //cbEleccion.SelectedIndex = 1;
            if (cbEleccion.SelectedIndex == 1)
            {
                this.ListarP();

            }
            else { this.ListarA(); }
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
            PersonaDesktop pers = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            pers.ShowDialog();

            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2) { ListarP(); }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pers = new PersonaDesktop(id, ApplicationForm.ModoForm.Modificacion);
            pers.ShowDialog();
            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2) { ListarP(); }
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pers = new PersonaDesktop(id, ApplicationForm.ModoForm.Baja);
            pers.ShowDialog();
            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2)
            {
                ListarP();
            }
        }

        private void tlPersonas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tcPersonas_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void cbEleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEleccion.SelectedIndex == 1)
            {
                this.ListarP();

            }
            else { this.ListarA(); }
        }

        private void tsbNuevo_Click_1(object sender, EventArgs e)
        {
            PersonaDesktop pers = new PersonaDesktop(ApplicationForm.ModoForm.Alta);
            pers.ShowDialog();

            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2) { ListarP(); }
        }

        private void tsbEditar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pers = new PersonaDesktop(id, ApplicationForm.ModoForm.Modificacion);
            pers.ShowDialog();
            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2) { ListarP(); }
        }

        private void tsbEliminar_Click_1(object sender, EventArgs e)
        {
            int id = ((Business.Entities.Personas)this.dgvPersonas.SelectedRows[0].DataBoundItem).ID;
            PersonaDesktop pers = new PersonaDesktop(id, ApplicationForm.ModoForm.Baja);
            pers.ShowDialog();
            if (pers.dev() == 1)
            {
                this.ListarA();
            }
            else if (pers.dev() == 2)
            {
                ListarP();
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            this.Listar();
        }
    }
}
