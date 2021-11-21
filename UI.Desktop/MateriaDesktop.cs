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
    public partial class MateriaDesktop : ApplicationForm
    {
        public MateriaDesktop()
        {
            InitializeComponent();
        }

        private Materia _MateriaActual;

        public Materia MateriaActual
        {
            get { return _MateriaActual; }
            set { _MateriaActual = value; }
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public MateriaDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            MateriaLogic usrl = new MateriaLogic();
            MateriaActual = usrl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.MateriaActual.ID.ToString();
            this.txtDescripcion.Text = this.MateriaActual.Descripcion;
            this.txtHsSemanales.Text = this.MateriaActual.HsSemanales.ToString();
            this.txtHsTotales.Text = this.MateriaActual.HsTotales.ToString();
            this.cbPlan.SelectedValue = this.MateriaActual.IdPlan.ToString();


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
                        Materia mat = new Materia();
                        MateriaActual = mat;
                        this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                        this.MateriaActual.HsSemanales = int.Parse (this.txtHsSemanales.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHsTotales.Text);
                        this.MateriaActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        MateriaActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.MateriaActual.ID = int.Parse(this.txtID.Text);
                        this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                        this.MateriaActual.HsSemanales = int.Parse(this.txtHsSemanales.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHsTotales.Text);
                        this.MateriaActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        MateriaActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.MateriaActual.ID = int.Parse(this.txtID.Text);
                        this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                        this.MateriaActual.HsSemanales = int.Parse(this.txtHsSemanales.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHsTotales.Text);
                        this.MateriaActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        MateriaActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.MateriaActual.Descripcion = this.txtDescripcion.Text;
                        this.MateriaActual.HsSemanales = int.Parse(this.txtHsSemanales.Text);
                        this.MateriaActual.HsTotales = int.Parse(this.txtHsTotales.Text);
                        this.MateriaActual.IdPlan = Convert.ToInt32(this.cbPlan.SelectedValue);
                        MateriaActual.State = BusinessEntity.States.Modified;
                        break;
                    }
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic matl = new MateriaLogic();
            matl.Save(this.MateriaActual);
        }

        public override bool Validar()
        {
            bool resp = false;
            string rta, msj = "Aviso";

            if (txtDescripcion.Text != "")
            {
                if (txtHsSemanales.Text != "")
                {
                    if (txtHsTotales.Text != "")
                    {
                        if (cbPlan.ValueMember != "")
                        {
                            resp = true;
                        }
                        else
                        {
                            rta = "El campo Id de plan esta vacío";
                            Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        rta = "El campo Horas totales esta vacío";
                        Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    rta = "El campo Horas Semanales esta vacío";
                    Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                rta = "El campo Descripcion esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet6.planes' Puede moverla o quitarla según sea necesario.
            this.planesTableAdapter1.Fill(this.tp2_netDataSet6.planes);
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet5.planes' Puede moverla o quitarla según sea necesario.
            //this.planesTableAdapter.Fill(this.tp2_netDataSet5.planes);

        }
    }
}
