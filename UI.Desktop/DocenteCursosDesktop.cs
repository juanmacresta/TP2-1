using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class DocenteCursosDesktop : ApplicationForm
    {
        public DocenteCursosDesktop()
        {
            InitializeComponent();
        }

        private Business.Entities.DocenteCurso _dcActual;

        public Business.Entities.DocenteCurso DcActual { get => _dcActual; set => _dcActual = value; }
        private void DocenteCursosDesktop_Load(object sender, EventArgs e)
        {
            CursoLogic curl = new CursoLogic();
            cbIDCurso.DataSource = curl.GetAll();
            cbIDCurso.DisplayMember = "IDCurso";
            cbIDCurso.ValueMember = "ID";
            cbCargo.SelectedIndex = 0;
        }

        public DocenteCursosDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public DocenteCursosDesktop(int id, ModoForm modo)
        {
            this.Modo = modo;
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            DcActual = dcl.GetOne(id);
            this.MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = this.DcActual.ID.ToString();
            this.txtIDDocente.Text = this.DcActual.IdDocente.ToString();
            this.cbCargo.Text = this.DcActual.Cargo.ToString();
            this.cbIDCurso.Text = this.DcActual.IdCurso.ToString();
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
                //default:
                //    {
                //        this.btnAceptar.Text = "Guardar";
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
                        Business.Entities.DocenteCurso Dc = new Business.Entities.DocenteCurso();
                        DcActual = Dc;
                        this.DcActual.IdCurso = int.Parse(cbIDCurso.SelectedValue.ToString());
                        this.DcActual.Cargo = int.Parse(cbCargo.SelectedIndex.ToString());
                        this.DcActual.IdDocente = int.Parse(this.txtIDDocente.Text);
                        DcActual.State = BusinessEntity.States.New;
                        break;
                    }
                case ModoForm.Modificacion:
                    {
                        this.DcActual.ID = int.Parse(txtID.Text);
                        this.DcActual.IdCurso = int.Parse(cbIDCurso.SelectedValue.ToString());
                        this.DcActual.Cargo = int.Parse(cbCargo.SelectedValue.ToString());
                        this.DcActual.IdDocente = int.Parse(this.txtIDDocente.Text);
                        DcActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case ModoForm.Baja:
                    {
                        this.DcActual.ID = int.Parse(txtID.Text);
                        this.DcActual.IdCurso = int.Parse(cbIDCurso.SelectedValue.ToString());
                        this.DcActual.Cargo = int.Parse(cbCargo.SelectedValue.ToString());
                        this.DcActual.IdDocente = int.Parse(this.txtIDDocente.Text);
                        DcActual.State = BusinessEntity.States.Deleted;
                        break;
                    }
            }
        }
        public override void GuardarCambios()
        {
            MapearADatos();
            DocenteCursoLogic dcl = new DocenteCursoLogic();
            dcl.Save(this.DcActual);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override bool Validar()
        {
            bool rta = false;
            Regex rx = new Regex(@"^[0-9]{1,4}$");
            if (!txtIDDocente.Text.Equals(""))
            {
                if (rx.IsMatch(txtIDDocente.Text))
                {
                    PersonasLogic p = new PersonasLogic();
                    Business.Entities.Personas pe = p.GetOne(int.Parse(txtIDDocente.Text));
                    if (pe.ID != 0)
                    {
                        if (pe.TiposPersonas == 2)
                        {
                            DialogResult resul = MessageBox.Show(pe.Nombre + " " + pe.Apellido + "\n" + "Legajo:" + pe.Legajo, "Usted es:", MessageBoxButtons.YesNo);
                            if (resul == DialogResult.Yes)
                            {
                                rta = true;
                            }
                            else { MessageBox.Show("Vuelva a ingresar otro id"); }
                        }
                        else { MessageBox.Show("El id ingresado no es de un profesor"); }

                    }
                    else { MessageBox.Show("El id ingresado no existe o es mayor a 4 digitos"); }
                }
                else { MessageBox.Show("El id ingresado debe tener solo numeros"); }
            }
            else { MessageBox.Show("El id ingresado no puede ser vacio"); }
            return rta;
        }
    }
}
