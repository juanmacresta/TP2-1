﻿
namespace UI.Desktop
{
    partial class UsuarioDesktop
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
            this.tlUsuarioDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.tlUsuarioDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlUsuarioDesktop
            // 
            this.tlUsuarioDesktop.ColumnCount = 4;
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarioDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlUsuarioDesktop.Controls.Add(this.label1, 0, 0);
            this.tlUsuarioDesktop.Controls.Add(this.label2, 0, 1);
            this.tlUsuarioDesktop.Controls.Add(this.label3, 0, 2);
            this.tlUsuarioDesktop.Controls.Add(this.label4, 0, 3);
            this.tlUsuarioDesktop.Controls.Add(this.label6, 2, 1);
            this.tlUsuarioDesktop.Controls.Add(this.label5, 2, 2);
            this.tlUsuarioDesktop.Controls.Add(this.chkHabilitado, 2, 0);
            this.tlUsuarioDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlUsuarioDesktop.Controls.Add(this.txtNombre, 1, 1);
            this.tlUsuarioDesktop.Controls.Add(this.txtClave, 1, 3);
            this.tlUsuarioDesktop.Controls.Add(this.txtUsuario, 3, 2);
            this.tlUsuarioDesktop.Controls.Add(this.txtEmail, 1, 2);
            this.tlUsuarioDesktop.Controls.Add(this.label7, 2, 3);
            this.tlUsuarioDesktop.Controls.Add(this.txtConfirmarClave, 3, 3);
            this.tlUsuarioDesktop.Controls.Add(this.btnAceptar, 2, 4);
            this.tlUsuarioDesktop.Controls.Add(this.btnCancelar, 3, 4);
            this.tlUsuarioDesktop.Controls.Add(this.txtApellido, 3, 1);
            this.tlUsuarioDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlUsuarioDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlUsuarioDesktop.Name = "tlUsuarioDesktop";
            this.tlUsuarioDesktop.RowCount = 5;
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlUsuarioDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlUsuarioDesktop.Size = new System.Drawing.Size(598, 162);
            this.tlUsuarioDesktop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Clave";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Usuario";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(239, 3);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 7;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(53, 3);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(53, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(53, 81);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(180, 20);
            this.txtClave.TabIndex = 11;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(326, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(178, 20);
            this.txtUsuario.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(53, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Confirmar Clave";
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.Location = new System.Drawing.Point(326, 81);
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.PasswordChar = '*';
            this.txtConfirmarClave.Size = new System.Drawing.Size(178, 20);
            this.txtConfirmarClave.TabIndex = 14;
            this.txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(239, 107);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 107);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(326, 29);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(178, 20);
            this.txtApellido.TabIndex = 12;
            // 
            // UsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 162);
            this.Controls.Add(this.tlUsuarioDesktop);
            this.Name = "UsuarioDesktop";
            this.Text = "UsuarioDesktop";
            this.Load += new System.EventHandler(this.UsuarioDesktop_Load);
            this.tlUsuarioDesktop.ResumeLayout(false);
            this.tlUsuarioDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlUsuarioDesktop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}