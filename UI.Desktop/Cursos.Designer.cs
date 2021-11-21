
namespace UI.Desktop
{
    partial class Cursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cursos));
            this.tcCurso = new System.Windows.Forms.ToolStripContainer();
            this.tlCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCurso = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsCurso = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.listaCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaCursosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.ListaCursosTableAdapter();
            this.tp2_netDataSet2 = new UI.Desktop.tp2_netDataSet2();
            this.listasCursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listasCursosTableAdapter = new UI.Desktop.tp2_netDataSet2TableAdapters.ListasCursosTableAdapter();
            this.tp2netDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listasCursosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descmateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desccomisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcurso1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aniocalendarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcCurso.ContentPanel.SuspendLayout();
            this.tcCurso.TopToolStripPanel.SuspendLayout();
            this.tcCurso.SuspendLayout();
            this.tlCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).BeginInit();
            this.tsCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasCursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2netDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasCursosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcCurso
            // 
            // 
            // tcCurso.ContentPanel
            // 
            this.tcCurso.ContentPanel.Controls.Add(this.tlCurso);
            this.tcCurso.ContentPanel.Size = new System.Drawing.Size(1286, 425);
            this.tcCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcCurso.Location = new System.Drawing.Point(0, 0);
            this.tcCurso.Name = "tcCurso";
            this.tcCurso.Size = new System.Drawing.Size(1286, 450);
            this.tcCurso.TabIndex = 0;
            this.tcCurso.Text = "toolStripContainer1";
            // 
            // tcCurso.TopToolStripPanel
            // 
            this.tcCurso.TopToolStripPanel.Controls.Add(this.tsCurso);
            // 
            // tlCurso
            // 
            this.tlCurso.ColumnCount = 2;
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlCurso.Controls.Add(this.dgvCurso, 0, 0);
            this.tlCurso.Controls.Add(this.btnActualizar, 0, 1);
            this.tlCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tlCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlCurso.Location = new System.Drawing.Point(0, 0);
            this.tlCurso.Name = "tlCurso";
            this.tlCurso.RowCount = 2;
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlCurso.Size = new System.Drawing.Size(1286, 425);
            this.tlCurso.TabIndex = 0;
            // 
            // dgvCurso
            // 
            this.dgvCurso.AutoGenerateColumns = false;
            this.dgvCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcursoDataGridViewTextBoxColumn,
            this.idmateriaDataGridViewTextBoxColumn,
            this.idcomisionDataGridViewTextBoxColumn,
            this.descmateriaDataGridViewTextBoxColumn,
            this.desccomisionDataGridViewTextBoxColumn,
            this.idcurso1DataGridViewTextBoxColumn,
            this.aniocalendarioDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn});
            this.tlCurso.SetColumnSpan(this.dgvCurso, 2);
            this.dgvCurso.DataSource = this.listasCursosBindingSource1;
            this.dgvCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvCurso.MultiSelect = false;
            this.dgvCurso.Name = "dgvCurso";
            this.dgvCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurso.Size = new System.Drawing.Size(1280, 390);
            this.dgvCurso.TabIndex = 0;
            this.dgvCurso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurso_CellContentClick);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(1127, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1208, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsCurso
            // 
            this.tsCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsCurso.Location = new System.Drawing.Point(3, 0);
            this.tsCurso.Name = "tsCurso";
            this.tsCurso.Size = new System.Drawing.Size(111, 25);
            this.tsCurso.TabIndex = 0;
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
            this.tsbNuevo.Visible = false;
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
            this.tsbEditar.Visible = false;
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
            this.tsbEliminar.Visible = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
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
            // tp2_netDataSet2
            // 
            this.tp2_netDataSet2.DataSetName = "tp2_netDataSet2";
            this.tp2_netDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listasCursosBindingSource
            // 
            this.listasCursosBindingSource.DataMember = "ListasCursos";
            this.listasCursosBindingSource.DataSource = this.tp2_netDataSet2;
            // 
            // listasCursosTableAdapter
            // 
            this.listasCursosTableAdapter.ClearBeforeFill = true;
            // 
            // tp2netDataSet2BindingSource
            // 
            this.tp2netDataSet2BindingSource.DataSource = this.tp2_netDataSet2;
            this.tp2netDataSet2BindingSource.Position = 0;
            // 
            // listasCursosBindingSource1
            // 
            this.listasCursosBindingSource1.DataMember = "ListasCursos";
            this.listasCursosBindingSource1.DataSource = this.tp2netDataSet2BindingSource;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idmateriaDataGridViewTextBoxColumn
            // 
            this.idmateriaDataGridViewTextBoxColumn.DataPropertyName = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.HeaderText = "id_materia";
            this.idmateriaDataGridViewTextBoxColumn.Name = "idmateriaDataGridViewTextBoxColumn";
            // 
            // idcomisionDataGridViewTextBoxColumn
            // 
            this.idcomisionDataGridViewTextBoxColumn.DataPropertyName = "id_comision";
            this.idcomisionDataGridViewTextBoxColumn.HeaderText = "id_comision";
            this.idcomisionDataGridViewTextBoxColumn.Name = "idcomisionDataGridViewTextBoxColumn";
            // 
            // descmateriaDataGridViewTextBoxColumn
            // 
            this.descmateriaDataGridViewTextBoxColumn.DataPropertyName = "desc_materia";
            this.descmateriaDataGridViewTextBoxColumn.HeaderText = "desc_materia";
            this.descmateriaDataGridViewTextBoxColumn.Name = "descmateriaDataGridViewTextBoxColumn";
            // 
            // desccomisionDataGridViewTextBoxColumn
            // 
            this.desccomisionDataGridViewTextBoxColumn.DataPropertyName = "desc_comision";
            this.desccomisionDataGridViewTextBoxColumn.HeaderText = "desc_comision";
            this.desccomisionDataGridViewTextBoxColumn.Name = "desccomisionDataGridViewTextBoxColumn";
            // 
            // idcurso1DataGridViewTextBoxColumn
            // 
            this.idcurso1DataGridViewTextBoxColumn.DataPropertyName = "id_curso1";
            this.idcurso1DataGridViewTextBoxColumn.HeaderText = "id_curso1";
            this.idcurso1DataGridViewTextBoxColumn.Name = "idcurso1DataGridViewTextBoxColumn";
            this.idcurso1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aniocalendarioDataGridViewTextBoxColumn
            // 
            this.aniocalendarioDataGridViewTextBoxColumn.DataPropertyName = "anio_calendario";
            this.aniocalendarioDataGridViewTextBoxColumn.HeaderText = "anio_calendario";
            this.aniocalendarioDataGridViewTextBoxColumn.Name = "aniocalendarioDataGridViewTextBoxColumn";
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "cupo";
            this.cupoDataGridViewTextBoxColumn.HeaderText = "cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            // 
            // Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 450);
            this.Controls.Add(this.tcCurso);
            this.Name = "Cursos";
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.Cursos_Load);
            this.tcCurso.ContentPanel.ResumeLayout(false);
            this.tcCurso.TopToolStripPanel.ResumeLayout(false);
            this.tcCurso.TopToolStripPanel.PerformLayout();
            this.tcCurso.ResumeLayout(false);
            this.tcCurso.PerformLayout();
            this.tlCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurso)).EndInit();
            this.tsCurso.ResumeLayout(false);
            this.tsCurso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasCursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2netDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listasCursosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcCurso;
        private System.Windows.Forms.TableLayoutPanel tlCurso;
        private System.Windows.Forms.DataGridView dgvCurso;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsCurso;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource listaCursosBindingSource;
        private tp2_netDataSetTableAdapters.ListaCursosTableAdapter listaCursosTableAdapter;
        private tp2_netDataSet2 tp2_netDataSet2;
        private System.Windows.Forms.BindingSource listasCursosBindingSource;
        private tp2_netDataSet2TableAdapters.ListasCursosTableAdapter listasCursosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descmateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desccomisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcurso1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aniocalendarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource listasCursosBindingSource1;
        private System.Windows.Forms.BindingSource tp2netDataSet2BindingSource;
    }
}