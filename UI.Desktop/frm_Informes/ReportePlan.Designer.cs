
namespace UI.Desktop.frm_Informes
{
    partial class ReportePlan
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
            this.tp2_netDataSet1 = new UI.Desktop.tp2_netDataSet1();
            this.spListaPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ListaPlanesTableAdapter = new UI.Desktop.tp2_netDataSet1TableAdapters.sp_ListaPlanesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaPlanesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 32;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spListaPlanesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Desktop.Informe.ReportePlanes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 448);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // tp2_netDataSet1
            // 
            this.tp2_netDataSet1.DataSetName = "tp2_netDataSet1";
            this.tp2_netDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spListaPlanesBindingSource
            // 
            this.spListaPlanesBindingSource.DataMember = "sp_ListaPlanes";
            this.spListaPlanesBindingSource.DataSource = this.tp2_netDataSet1;
            // 
            // sp_ListaPlanesTableAdapter
            // 
            this.sp_ListaPlanesTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePlan";
            this.Text = "ReportePlan";
            this.Load += new System.EventHandler(this.ReportePlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spListaPlanesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private tp2_netDataSet1 tp2_netDataSet1;
        private System.Windows.Forms.BindingSource spListaPlanesBindingSource;
        private tp2_netDataSet1TableAdapters.sp_ListaPlanesTableAdapter sp_ListaPlanesTableAdapter;
    }
}