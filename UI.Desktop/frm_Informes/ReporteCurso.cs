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

namespace UI.Desktop.frm_Informes
{
    public partial class ReporteCurso : Form
    {
        public ReporteCurso()
        {
            InitializeComponent();
        }

        private void ReportePlanes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.ListaCursos' Puede moverla o quitarla según sea necesario.
            this.listaCursosTableAdapter.Fill(this.tp2_netDataSet.ListaCursos);

           

            this.reportViewer1.RefreshReport();

        }

        private void CursoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            

            this.reportViewer1.RefreshReport();
        }
    }
}
