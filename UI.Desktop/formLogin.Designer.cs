
namespace UI.Desktop
{
    partial class formLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nomUsuTxt = new System.Windows.Forms.TextBox();
            this.contrasenaTxt = new System.Windows.Forms.TextBox();
            this.ingresarBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // nomUsuTxt
            // 
            this.nomUsuTxt.Location = new System.Drawing.Point(140, 22);
            this.nomUsuTxt.Name = "nomUsuTxt";
            this.nomUsuTxt.Size = new System.Drawing.Size(181, 20);
            this.nomUsuTxt.TabIndex = 2;
            // 
            // contrasenaTxt
            // 
            this.contrasenaTxt.Location = new System.Drawing.Point(140, 66);
            this.contrasenaTxt.Name = "contrasenaTxt";
            this.contrasenaTxt.PasswordChar = '*';
            this.contrasenaTxt.Size = new System.Drawing.Size(181, 20);
            this.contrasenaTxt.TabIndex = 3;
            this.contrasenaTxt.UseSystemPasswordChar = true;
            // 
            // ingresarBtn
            // 
            this.ingresarBtn.Location = new System.Drawing.Point(140, 128);
            this.ingresarBtn.Name = "ingresarBtn";
            this.ingresarBtn.Size = new System.Drawing.Size(81, 29);
            this.ingresarBtn.TabIndex = 4;
            this.ingresarBtn.Text = "Ingresar";
            this.ingresarBtn.UseVisualStyleBackColor = true;
            this.ingresarBtn.Click += new System.EventHandler(this.ingresarBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Desktop.Properties.Resources.utn_regional_rosario_200x200px;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 205);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ingresarBtn);
            this.Controls.Add(this.contrasenaTxt);
            this.Controls.Add(this.nomUsuTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "formLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomUsuTxt;
        private System.Windows.Forms.TextBox contrasenaTxt;
        private System.Windows.Forms.Button ingresarBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}