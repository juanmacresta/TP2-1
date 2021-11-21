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
    public partial class PlanDesktop :ApplicationForm
    {
        public PlanDesktop()
        {
            InitializeComponent();
        }

        private Business.Entities.Plan _PlanActual;
        public Business.Entities.Plan PlanActual { get => _PlanActual; set => _PlanActual = value; }
       

        public PlanDesktop(ModoForm modo) : this()
        {
            Modo = modo;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public PlanDesktop(int id, ModoForm modo) : this()
        {
            this.Modo = modo;
            PlanLogic usu = new PlanLogic();
            PlanActual = usu.GetOne(id);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {

            this.txtID.Text = this.PlanActual.ID.ToString();
            this.txtDesc.Text = this.PlanActual.Descripcion;
            this.txtEsp.Text = this.PlanActual.IdEspecialidad.ToString();


            switch (this.Modo)
            {
                case ModoForm.Alta:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.btnAceptar.Text = "Eliminar";
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.btnAceptar.Text = "Aceptar";
                        break;
                    }
                default:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
            }
        }
        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Plan pl = new Plan();
                        PlanActual = pl;
                        this.PlanActual.Descripcion = this.txtDesc.Text;
                        this.PlanActual.IdEspecialidad = int.Parse(this.txtEsp.Text);


                        PlanActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.PlanActual.ID = int.Parse(this.txtID.Text);
                        this.PlanActual.Descripcion = this.txtDesc.Text;
                        this.PlanActual.IdEspecialidad = int.Parse(this.txtEsp.Text);
                        PlanActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.PlanActual.ID = int.Parse(this.txtID.Text);
                        this.PlanActual.Descripcion = this.txtDesc.Text;
                        this.PlanActual.IdEspecialidad = int.Parse(this.txtEsp.Text);
                        PlanActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }

        }
        public override void GuardarCambios()
        {
            MapearADatos();
            PlanLogic plan = new PlanLogic();
            plan.Save(this.PlanActual);
        }

        public override bool Validar()
        {
            bool resp = false;
            PlanLogic plan = new PlanLogic();
            string rta;
            if (!("".Equals(txtDesc.Text)))
            {
                if (!("".Equals(txtEsp.Text)))
                {
                    if ((plan.ExisteEspecialidad(int.Parse(txtEsp.Text))))
                    {
                        resp = true;
                    }
                    else { { rta = "No existe Especialidad Asociada al ID: " + this.txtEsp.Text; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
                }
                else { { rta = "El ID de Especialidad no puede ser vacío"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            }
            else { { rta = "La descripción del Plan no puede ser vacía"; } this.Notificar(rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }
            return resp;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
