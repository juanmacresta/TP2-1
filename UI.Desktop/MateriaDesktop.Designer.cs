
namespace UI.Desktop
{
    partial class MateriaDesktop
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblHorasSemanales = new System.Windows.Forms.Label();
            this.lblHorasTotales = new System.Windows.Forms.Label();
            this.lblIdplan = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtHsSemanales = new System.Windows.Forms.TextBox();
            this.txtHsTotales = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.planesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet6 = new UI.Desktop.tp2_netDataSet6();
            this.tp2_netDataSet5 = new UI.Desktop.tp2_netDataSet5();
            this.planesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planesTableAdapter = new UI.Desktop.tp2_netDataSet5TableAdapters.planesTableAdapter();
            this.planesTableAdapter1 = new UI.Desktop.tp2_netDataSet6TableAdapters.planesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDescripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblHorasSemanales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHorasTotales, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblIdplan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtHsSemanales, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtHsTotales, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDescripcion, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbPlan, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 135);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(311, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblHorasSemanales
            // 
            this.lblHorasSemanales.AutoSize = true;
            this.lblHorasSemanales.Location = new System.Drawing.Point(3, 26);
            this.lblHorasSemanales.Name = "lblHorasSemanales";
            this.lblHorasSemanales.Size = new System.Drawing.Size(90, 13);
            this.lblHorasSemanales.TabIndex = 2;
            this.lblHorasSemanales.Text = "Horas Semanales";
            // 
            // lblHorasTotales
            // 
            this.lblHorasTotales.AutoSize = true;
            this.lblHorasTotales.Location = new System.Drawing.Point(311, 26);
            this.lblHorasTotales.Name = "lblHorasTotales";
            this.lblHorasTotales.Size = new System.Drawing.Size(73, 13);
            this.lblHorasTotales.TabIndex = 3;
            this.lblHorasTotales.Text = "Horas Totales";
            // 
            // lblIdplan
            // 
            this.lblIdplan.AutoSize = true;
            this.lblIdplan.Location = new System.Drawing.Point(3, 52);
            this.lblIdplan.Name = "lblIdplan";
            this.lblIdplan.Size = new System.Drawing.Size(54, 13);
            this.lblIdplan.TabIndex = 4;
            this.lblIdplan.Text = "Id de plan";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(311, 82);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(392, 82);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Cancelar";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(99, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(206, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtHsSemanales
            // 
            this.txtHsSemanales.Location = new System.Drawing.Point(99, 29);
            this.txtHsSemanales.Name = "txtHsSemanales";
            this.txtHsSemanales.Size = new System.Drawing.Size(206, 20);
            this.txtHsSemanales.TabIndex = 9;
            // 
            // txtHsTotales
            // 
            this.txtHsTotales.Location = new System.Drawing.Point(392, 29);
            this.txtHsTotales.Name = "txtHsTotales";
            this.txtHsTotales.Size = new System.Drawing.Size(205, 20);
            this.txtHsTotales.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(392, 3);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // cbPlan
            // 
            this.cbPlan.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.planesBindingSource1, "id_plan", true));
            this.cbPlan.DataSource = this.planesBindingSource1;
            this.cbPlan.DisplayMember = "desc_plan";
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(99, 55);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(206, 21);
            this.cbPlan.TabIndex = 11;
            this.cbPlan.ValueMember = "id_plan";
            // 
            // planesBindingSource1
            // 
            this.planesBindingSource1.DataMember = "planes";
            this.planesBindingSource1.DataSource = this.tp2_netDataSet6;
            // 
            // tp2_netDataSet6
            // 
            this.tp2_netDataSet6.DataSetName = "tp2_netDataSet6";
            this.tp2_netDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tp2_netDataSet5
            // 
            this.tp2_netDataSet5.DataSetName = "tp2_netDataSet5";
            this.tp2_netDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planesBindingSource
            // 
            this.planesBindingSource.DataMember = "planes";
            this.planesBindingSource.DataSource = this.tp2_netDataSet5;
            // 
            // planesTableAdapter
            // 
            this.planesTableAdapter.ClearBeforeFill = true;
            // 
            // planesTableAdapter1
            // 
            this.planesTableAdapter1.ClearBeforeFill = true;
            // 
            // MateriaDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 135);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MateriaDesktop";
            this.Text = "MateriaDesktop";
            this.Load += new System.EventHandler(this.MateriaDesktop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblHorasSemanales;
        private System.Windows.Forms.Label lblHorasTotales;
        private System.Windows.Forms.Label lblIdplan;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHsSemanales;
        private System.Windows.Forms.TextBox txtHsTotales;
        private System.Windows.Forms.ComboBox cbPlan;
        private tp2_netDataSet5 tp2_netDataSet5;
        private System.Windows.Forms.BindingSource planesBindingSource;
        private tp2_netDataSet5TableAdapters.planesTableAdapter planesTableAdapter;
        private tp2_netDataSet6 tp2_netDataSet6;
        private System.Windows.Forms.BindingSource planesBindingSource1;
        private tp2_netDataSet6TableAdapters.planesTableAdapter planesTableAdapter1;
    }
}