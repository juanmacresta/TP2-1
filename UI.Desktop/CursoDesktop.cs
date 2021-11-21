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
    public partial class CursoDesktop : ApplicationForm
    {
        public CursoDesktop()
        {
            InitializeComponent();
        }

        private Curso _CursoActual;

        public Curso CursoActual
        {
            get { return _CursoActual; }
            set { _CursoActual = value; }
        }

        public CursoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public CursoDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            CursoLogic usrl = new CursoLogic();
            CursoActual = usrl.GetOne(ID);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.CursoActual.ID.ToString();
            this.txtAnioCalendario.Text = this.CursoActual.AnioCalendario.ToString();
            
            this.txtCupo.Text = this.CursoActual.Cupo.ToString();
            this.cbComision.SelectedValue = this.CursoActual.IdComision.ToString();
            this.cbMateria.SelectedValue = this.CursoActual.IdMateria.ToString();

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
                        Curso cur = new Curso();
                        CursoActual = cur;
                        this.CursoActual.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
                        
                        this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                        this.CursoActual.IdComision = Convert.ToInt32(this.cbComision.SelectedValue);
                        this.CursoActual.IdMateria = Convert.ToInt32(this.cbMateria.SelectedValue);
                        CursoActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Consulta:
                    {
                        this.CursoActual.ID = int.Parse(this.txtID.Text);
                        this.CursoActual.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
                        
                        this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                        this.CursoActual.IdComision = Convert.ToInt32(this.cbComision.SelectedValue);
                        this.CursoActual.IdMateria = Convert.ToInt32(this.cbMateria.SelectedValue);
                        CursoActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.CursoActual.ID = int.Parse(this.txtID.Text);
                        this.CursoActual.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
                        
                        this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                        this.CursoActual.IdComision = Convert.ToInt32(this.cbComision.SelectedValue);
                        this.CursoActual.IdMateria = Convert.ToInt32(this.cbMateria.SelectedValue);
                        CursoActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.CursoActual.AnioCalendario = int.Parse(this.txtAnioCalendario.Text);
                        
                        this.CursoActual.Cupo = int.Parse(this.txtCupo.Text);
                        this.CursoActual.IdComision = Convert.ToInt32(this.cbComision.SelectedValue);
                        this.CursoActual.IdMateria = Convert.ToInt32(this.cbMateria.SelectedValue);
                        CursoActual.State = BusinessEntity.States.Modified;
                        break;
                    }
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            CursoLogic curl = new CursoLogic();
            curl.Save(this.CursoActual);
        }

        public override bool Validar()
        {
            bool resp = false;
            string rta, msj = "Aviso";
            int cont = 0;

            if (txtAnioCalendario.Text != "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo Año Calendario esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            

            if (txtCupo.Text != "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo Cupo esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (cbComision.Text != "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo ID Comisión esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (cbMateria.Text != "")
            {
                cont = cont + 1;
            }
            else
            {
                rta = "El campo ID Materia esta vacío";
                Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (cont == 5)
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

        private void CursoDesktop_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet9.comisiones' Puede moverla o quitarla según sea necesario.
            this.comisionesTableAdapter.Fill(this.tp2_netDataSet9.comisiones);
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet8.materias' Puede moverla o quitarla según sea necesario.
            this.materiasTableAdapter.Fill(this.tp2_netDataSet8.materias);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
}
