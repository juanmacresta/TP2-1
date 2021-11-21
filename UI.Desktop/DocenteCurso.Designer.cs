
namespace UI.Desktop
{
    partial class DocenteCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteCurso));
            this.tsCurso = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvDocCur = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tp2_netDataSet4 = new UI.Desktop.tp2_netDataSet4();
            this.listasDocentesCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listasDocentesCursosTableAdapter = new UI.Desktop.tp2_netDataSet4TableAdapters.ListasDocentesCursosTableAdapter();
            this.iddictadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddocenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocCur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasDocentesCursosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsCurso
            // 
            this.tsCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCurso.Location = new System.Drawing.Point(9, 9);
            this.tsCurso.Name = "tsCurso";
            this.tsCurso.Size = new System.Drawing.Size(81, 25);
            this.tsCurso.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "toolStripButton1";
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton1";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // dgvDocCur
            // 
            this.dgvDocCur.AutoGenerateColumns = false;
            this.dgvDocCur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocCur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddictadoDataGridViewTextBoxColumn,
            this.iddocenteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn});
            this.dgvDocCur.DataSource = this.listasDocentesCursosBindingSource;
            this.dgvDocCur.Location = new System.Drawing.Point(12, 37);
            this.dgvDocCur.Name = "dgvDocCur";
            this.dgvDocCur.Size = new System.Drawing.Size(776, 214);
            this.dgvDocCur.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(606, 257);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(88, 27);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(700, 257);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 27);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tp2_netDataSet4
            // 
            this.tp2_netDataSet4.DataSetName = "tp2_netDataSet4";
            this.tp2_netDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listasDocentesCursosBindingSource
            // 
            this.listasDocentesCursosBindingSource.DataMember = "ListasDocentesCursos";
            this.listasDocentesCursosBindingSource.DataSource = this.tp2_netDataSet4;
            // 
            // listasDocentesCursosTableAdapter
            // 
            this.listasDocentesCursosTableAdapter.ClearBeforeFill = true;
            // 
            // iddictadoDataGridViewTextBoxColumn
            // 
            this.iddictadoDataGridViewTextBoxColumn.DataPropertyName = "id_dictado";
            this.iddictadoDataGridViewTextBoxColumn.HeaderText = "id_dictado";
            this.iddictadoDataGridViewTextBoxColumn.Name = "iddictadoDataGridViewTextBoxColumn";
            this.iddictadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddocenteDataGridViewTextBoxColumn
            // 
            this.iddocenteDataGridViewTextBoxColumn.DataPropertyName = "id_docente";
            this.iddocenteDataGridViewTextBoxColumn.HeaderText = "id_docente";
            this.iddocenteDataGridViewTextBoxColumn.Name = "iddocenteDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            // 
            // DocenteCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvDocCur);
            this.Controls.Add(this.tsCurso);
            this.Name = "DocenteCurso";
            this.Text = "DocenteCurso";
            this.Load += new System.EventHandler(this.DocenteCurso_Load);
            this.tsCurso.ResumeLayout(false);
            this.tsCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocCur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasDocentesCursosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCurso;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dgvDocCur;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private tp2_netDataSet4 tp2_netDataSet4;
        private System.Windows.Forms.BindingSource listasDocentesCursosBindingSource;
        private tp2_netDataSet4TableAdapters.ListasDocentesCursosTableAdapter listasDocentesCursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddictadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddocenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
    }
}