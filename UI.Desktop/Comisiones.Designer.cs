﻿
namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.tcComision = new System.Windows.Forms.ToolStripContainer();
            this.tlComision = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComision = new System.Windows.Forms.DataGridView();
            this.anioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsComision = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcComision.ContentPanel.SuspendLayout();
            this.tcComision.TopToolStripPanel.SuspendLayout();
            this.tcComision.SuspendLayout();
            this.tlComision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComision)).BeginInit();
            this.tsComision.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcComision
            // 
            // 
            // tcComision.ContentPanel
            // 
            this.tcComision.ContentPanel.Controls.Add(this.tlComision);
            this.tcComision.ContentPanel.Size = new System.Drawing.Size(800, 425);
            this.tcComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcComision.Location = new System.Drawing.Point(0, 0);
            this.tcComision.Name = "tcComision";
            this.tcComision.Size = new System.Drawing.Size(800, 450);
            this.tcComision.TabIndex = 0;
            this.tcComision.Text = "toolStripContainer1";
            // 
            // tcComision.TopToolStripPanel
            // 
            this.tcComision.TopToolStripPanel.Controls.Add(this.tsComision);
            // 
            // tlComision
            // 
            this.tlComision.ColumnCount = 2;
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlComision.Controls.Add(this.dgvComision, 0, 0);
            this.tlComision.Controls.Add(this.btnActualizar, 0, 1);
            this.tlComision.Controls.Add(this.btnSalir, 1, 1);
            this.tlComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComision.Location = new System.Drawing.Point(0, 0);
            this.tlComision.Name = "tlComision";
            this.tlComision.RowCount = 2;
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComision.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComision.Size = new System.Drawing.Size(800, 425);
            this.tlComision.TabIndex = 0;
            // 
            // dgvComision
            // 
            this.dgvComision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.anioEspecialidad,
            this.descripcion,
            this.idPlan,
            this.ID});
            this.tlComision.SetColumnSpan(this.dgvComision, 2);
            this.dgvComision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComision.Location = new System.Drawing.Point(3, 3);
            this.dgvComision.MultiSelect = false;
            this.dgvComision.Name = "dgvComision";
            this.dgvComision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComision.Size = new System.Drawing.Size(794, 390);
            this.dgvComision.TabIndex = 0;
            this.dgvComision.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComision_CellContentClick);
            // 
            // anioEspecialidad
            // 
            this.anioEspecialidad.DataPropertyName = "AnioEspecialidad";
            this.anioEspecialidad.HeaderText = "Año Especialidad";
            this.anioEspecialidad.Name = "anioEspecialidad";
            this.anioEspecialidad.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "IdPlan";
            this.idPlan.HeaderText = "ID plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(641, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(722, 399);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsComision
            // 
            this.tsComision.Dock = System.Windows.Forms.DockStyle.None;
            this.tsComision.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsComision.Location = new System.Drawing.Point(3, 0);
            this.tsComision.Name = "tsComision";
            this.tsComision.Size = new System.Drawing.Size(112, 25);
            this.tsComision.TabIndex = 0;
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
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcComision);
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.tcComision.ContentPanel.ResumeLayout(false);
            this.tcComision.TopToolStripPanel.ResumeLayout(false);
            this.tcComision.TopToolStripPanel.PerformLayout();
            this.tcComision.ResumeLayout(false);
            this.tcComision.PerformLayout();
            this.tlComision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComision)).EndInit();
            this.tsComision.ResumeLayout(false);
            this.tsComision.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcComision;
        private System.Windows.Forms.TableLayoutPanel tlComision;
        private System.Windows.Forms.DataGridView dgvComision;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsComision;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioEspecialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}