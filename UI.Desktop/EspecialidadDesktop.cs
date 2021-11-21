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
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }

        private Especialidad _EspecialidadActual;

        public Especialidad EspecialidadActual
        {
            get { return _EspecialidadActual; }
            set { _EspecialidadActual = value; }
        }

        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            EspecialidadLogic usrl = new EspecialidadLogic();
            EspecialidadActual = usrl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.EspecialidadActual.ID.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

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
                        Especialidad usr = new Especialidad();
                        EspecialidadActual = usr;
                        this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                        EspecialidadActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                        this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                        EspecialidadActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.EspecialidadActual.ID = int.Parse(this.txtID.Text);
                        this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                        EspecialidadActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                        EspecialidadActual.State = BusinessEntity.States.Modified;
                        break;
                    }
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            EspecialidadLogic espl = new EspecialidadLogic();
            espl.Save(this.EspecialidadActual);
        }

        public override bool Validar()
        {
            bool resp = false;
            string rta, msj = "Aviso";

            if (txtDescripcion.Text != "")
            {
                resp = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EspecialidadDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
