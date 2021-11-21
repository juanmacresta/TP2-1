
namespace UI.Desktop.frm_Informes
{
    partial class ReporteCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.listaCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCursosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.ListaCursosTableAdapter();
            this.CursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.listaCursosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Informe.ReporteCursos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, -3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(926, 478);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listaCursosBindingSource
            // 
            this.listaCursosBindingSource.DataMember = "ListaCursos";
            this.listaCursosBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // listaCursosTableAdapter
            // 
            this.listaCursosTableAdapter.ClearBeforeFill = true;
            // 
            // CursoBindingSource
            // 
            this.CursoBindingSource.DataSource = typeof(Business.Entities.Curso);
            this.CursoBindingSource.CurrentChanged += new System.EventHandler(this.CursoBindingSource_CurrentChanged);
            // 
            // ReporteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 473);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCurso";
            this.Text = "ReportePlan";
            this.Load += new System.EventHandler(this.ReportePlanes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CursoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CursoBindingSource;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource listaCursosBindingSource;
        private tp2_netDataSetTableAdapters.ListaCursosTableAdapter listaCursosTableAdapter;
    }
}