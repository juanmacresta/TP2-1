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
    public partial class AlumnosInscripcionesDesktop : ApplicationForm
    {
        private Business.Entities.AlumnoInscripcion _AIActual;
        private Business.Entities.Personas _PA;
        public Business.Entities.Personas PA { get => _PA; set => _PA = value; }

        public Business.Entities.AlumnoInscripcion AIActual { get => _AIActual; set => this._AIActual = value; }
        public AlumnosInscripcionesDesktop()
        {
            InitializeComponent();
            
        }
        

        private void AlumnosInscripcionesDesktop_Load(object sender, EventArgs e)
        {

            txtID.Visible = false;





            
            if (Modo == ModoForm.Alta)
            {
                txtIDAlum.ReadOnly = true;
                cbCondicion.Visible = false;
                cbNota.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                cbNota.Visible = false;
                CursoLogic c = new CursoLogic();
                cbCursos.DataSource = c.GetAll();
                cbCursos.DisplayMember = "id";
                cbCursos.ValueMember = "id";
                cbCondicion.SelectedIndex = 0;

            }
            else if (Modo == ModoForm.Modificacion)
            {
                txtIDAlum.Enabled = false;
                cbCursos.Enabled = true;
                

            }
            else
            {
                txtIDAlum.ReadOnly = true;
                txtIDAlum.Enabled = false;
                cbCondicion.Enabled = false;
                cbCursos.Enabled = true;
                cbNota.Enabled = false;
                

            }
        }
        public AlumnosInscripcionesDesktop( Business.Entities.Personas per, ModoForm modo) : this()
        {
            this.Modo = modo;
            PA = per;
            this.txtIDAlum.Text = PA.ID.ToString();
            
            
        }
        public AlumnosInscripcionesDesktop(int ida, int idc, ModoForm modo) : this()
        {
            this.Modo = modo;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            AIActual = ail.GetOne(ida, idc);
            
            this.MapearDeDatos();
        }
        public AlumnosInscripcionesDesktop(Business.Entities.Personas per, int ida, int idc, ModoForm modo) : this()
        {
            this.Modo = modo;
            PA = per;
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            AIActual = ail.GetOne(ida, idc);

            this.MapearDeDatos();
        }
        public override void MapearDeDatos()
        {
            this.txtID.Text = this.AIActual.ID.ToString();
            this.txtIDAlum.Text = this.AIActual.IdAlumno.ToString();
            this.cbCondicion.Text = this.AIActual.Condicion;
            this.cbCursos.Text = this.AIActual.IdCurso.ToString();
            this.cbNota.Text = this.AIActual.Nota.ToString();
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
                        AlumnoInscripcion ai = new AlumnoInscripcion();
                        AIActual = ai;
                        this.AIActual.IdAlumno = int.Parse(txtIDAlum.Text);
                        this.AIActual.IdCurso = int.Parse(cbCursos.Text.ToString());
                        this.AIActual.Condicion = cbCondicion.SelectedItem.ToString();
                        AIActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.AIActual.ID = int.Parse(txtID.Text);
                        this.AIActual.IdAlumno = int.Parse(txtIDAlum.Text);
                        this.AIActual.IdCurso = int.Parse(cbCursos.Text.ToString());
                        this.AIActual.Condicion = cbCondicion.SelectedItem.ToString();
                        this.AIActual.Nota = cbNota.SelectedIndex + 1;
                        AIActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.AIActual.ID = int.Parse(txtID.Text);
                        this.AIActual.IdAlumno = int.Parse(txtIDAlum.Text);
                        this.AIActual.IdCurso = int.Parse(cbCursos.Text.ToString());
                        this.AIActual.Condicion = cbCondicion.SelectedItem.ToString();
                        this.AIActual.Nota = cbNota.SelectedIndex + 1;
                        AIActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoInscripcionLogic ail = new AlumnoInscripcionLogic();
            ail.Save(this.AIActual);
        }

        private void tp2netDataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Presiones si para confirmar la inscripcion", "Confirmar Inscripcion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.GuardarCambios();
                this.Close();
            }


        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if(Validar())
            {
                if (MessageBox.Show("Presiones si para confirmar la inscripcion", "Confirmar Inscripcion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.GuardarCambios();
                    this.Close();
                }
            }
            
        }
        public override bool Validar()
        {
            bool resp = true;
            string rta, msj = "Aviso";
            int cont = 0;
            if(Modo==ModoForm.Baja)
            {
                if (txtIDAlum.Text != PA.ID.ToString())
                {
                    rta = "Su id no coincide con el del Alumno seleccionado";
                    Notificar(msj, rta, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    resp = false;
                }
                else
                {
                    resp = true;
                }
            }
            
            return resp;
        }
            private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
