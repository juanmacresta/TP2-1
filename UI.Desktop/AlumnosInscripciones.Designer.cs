
namespace UI.Desktop
{
    partial class AlumnosInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosInscripciones));
            this.tsMaterias = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.dgvAluIns = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tp2_netDataSet3 = new UI.Desktop.tp2_netDataSet3();
            this.listasAlumnosInscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listasAlumnosInscripcionTableAdapter = new UI.Desktop.tp2_netDataSet3TableAdapters.ListasAlumnosInscripcionTableAdapter();
            this.idinscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluIns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasAlumnosInscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMaterias
            // 
            this.tsMaterias.Dock = System.Windows.Forms.DockStyle.None;
            this.tsMaterias.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsMaterias.Location = new System.Drawing.Point(9, 9);
            this.tsMaterias.Name = "tsMaterias";
            this.tsMaterias.Size = new System.Drawing.Size(81, 25);
            this.tsMaterias.TabIndex = 1;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
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
            this.tsbEditar.ToolTipText = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click_1);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click_1);
            // 
            // dgvAluIns
            // 
            this.dgvAluIns.AutoGenerateColumns = false;
            this.dgvAluIns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluIns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinscripcionDataGridViewTextBoxColumn,
            this.idalumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.condicionDataGridViewTextBoxColumn,
            this.notaDataGridViewTextBoxColumn});
            this.dgvAluIns.DataSource = this.listasAlumnosInscripcionBindingSource;
            this.dgvAluIns.Location = new System.Drawing.Point(9, 37);
            this.dgvAluIns.Name = "dgvAluIns";
            this.dgvAluIns.Size = new System.Drawing.Size(956, 267);
            this.dgvAluIns.TabIndex = 2;
            this.dgvAluIns.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAluIns_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(815, 310);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(719, 310);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // tp2_netDataSet3
            // 
            this.tp2_netDataSet3.DataSetName = "tp2_netDataSet3";
            this.tp2_netDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listasAlumnosInscripcionBindingSource
            // 
            this.listasAlumnosInscripcionBindingSource.DataMember = "ListasAlumnosInscripcion";
            this.listasAlumnosInscripcionBindingSource.DataSource = this.tp2_netDataSet3;
            // 
            // listasAlumnosInscripcionTableAdapter
            // 
            this.listasAlumnosInscripcionTableAdapter.ClearBeforeFill = true;
            // 
            // idinscripcionDataGridViewTextBoxColumn
            // 
            this.idinscripcionDataGridViewTextBoxColumn.DataPropertyName = "id_inscripcion";
            this.idinscripcionDataGridViewTextBoxColumn.HeaderText = "id_inscripcion";
            this.idinscripcionDataGridViewTextBoxColumn.Name = "idinscripcionDataGridViewTextBoxColumn";
            this.idinscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idalumnoDataGridViewTextBoxColumn
            // 
            this.idalumnoDataGridViewTextBoxColumn.DataPropertyName = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.HeaderText = "id_alumno";
            this.idalumnoDataGridViewTextBoxColumn.Name = "idalumnoDataGridViewTextBoxColumn";
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
            // condicionDataGridViewTextBoxColumn
            // 
            this.condicionDataGridViewTextBoxColumn.DataPropertyName = "condicion";
            this.condicionDataGridViewTextBoxColumn.HeaderText = "condicion";
            this.condicionDataGridViewTextBoxColumn.Name = "condicionDataGridViewTextBoxColumn";
            // 
            // notaDataGridViewTextBoxColumn
            // 
            this.notaDataGridViewTextBoxColumn.DataPropertyName = "nota";
            this.notaDataGridViewTextBoxColumn.HeaderText = "nota";
            this.notaDataGridViewTextBoxColumn.Name = "notaDataGridViewTextBoxColumn";
            // 
            // AlumnosInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 337);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.dgvAluIns);
            this.Controls.Add(this.tsMaterias);
            this.Name = "AlumnosInscripciones";
            this.Text = "AlumnosInscripciones";
            this.Load += new System.EventHandler(this.AlumnosInscripciones_Load);
            this.tsMaterias.ResumeLayout(false);
            this.tsMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluIns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasAlumnosInscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMaterias;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridView dgvAluIns;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private tp2_netDataSet3 tp2_netDataSet3;
        private System.Windows.Forms.BindingSource listasAlumnosInscripcionBindingSource;
        private tp2_netDataSet3TableAdapters.ListasAlumnosInscripcionTableAdapter listasAlumnosInscripcionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notaDataGridViewTextBoxColumn;
    }
}