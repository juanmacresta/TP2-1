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
    public partial class ComisionDesktop : ApplicationForm
    {
        public ComisionDesktop()
        {
            InitializeComponent();
        }

        private Comision _ComisionActual;

        public Comision ComisionActual
        {
            get { return _ComisionActual; }
            set { _ComisionActual = value; }
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public ComisionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            ComisionLogic usrl = new ComisionLogic();
            ComisionActual = usrl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.ComisionActual.ID.ToString();
            this.txtAñoEspecialidad.Text = this.ComisionActual.AnioEspecialidad.ToString();
            this.txtDescripcion.Text = this.ComisionActual.Descripcion;
            this.cbPlan.SelectedValue = this.ComisionActual.IdPlan.ToString();

            switch (this.Modo)
            {
                case ModoForm.Alta:
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
                case ModoForm.Modificacion:
                    {
                        this.btnAceptar.Text = "Guardar";
                        break;
                    }
                    //default:
                    //    {
                    //        this.btnAceptar.Text = "Aceptar";
                    //        break;
                    //    }
            }
        }

        public override void MapearADatos()
        {
            switch (Modo)
            {
                case ModoForm.Alta:
                    {
                        Comision usr = new Comision();
                        ComisionActual = usr;
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAñoEspecialidad.Text);
                        this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                        this.ComisionActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        ComisionActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.ComisionActual.ID = int.Parse(this.txtID.Text);
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAñoEspecialidad.Text);
                        this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                        this.ComisionActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        ComisionActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.ComisionActual.ID = int.Parse(this.txtID.Text);
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAñoEspecialidad.Text);
                        this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                        this.ComisionActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        ComisionActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.ComisionActual.AnioEspecialidad = int.Parse(this.txtAñoEspecialidad.Text);
                        this.ComisionActual.Descripcion = this.txtDescripcion.Text;
                        this.ComisionActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        ComisionActual.State = BusinessEntity.States.Modified;
                        break;
                    }
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic usrl = new ComisionLogic();
            usrl.Save(this.ComisionActual);
        }

        public override bool Validar()
        {
            bool resp = false;
            string rta, msj = "Aviso";
            int cont = 0;

            if (txtAñoEspecialidad.Text != "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo Año Especialidad esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (txtDescripcion.Text != "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo Descripción esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (cbPlan.Text!= "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo ID Plan esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } 

            if (cont == 3)
            {
                resp = true;
            }
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

        private void ComisionDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet7.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter.Fill(this.tp2_netDataSet7.planes);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
