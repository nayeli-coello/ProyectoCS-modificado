namespace ProyectoCS
{
    partial class FrmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txtusu = new System.Windows.Forms.TextBox();
            this.Txtcontr = new System.Windows.Forms.TextBox();
            this.Btnacep = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtusu
            // 
            this.Txtusu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txtusu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtusu.ForeColor = System.Drawing.SystemColors.Window;
            this.Txtusu.Location = new System.Drawing.Point(12, 28);
            this.Txtusu.Name = "Txtusu";
            this.Txtusu.Size = new System.Drawing.Size(218, 20);
            this.Txtusu.TabIndex = 4;
            // 
            // Txtcontr
            // 
            this.Txtcontr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Txtcontr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txtcontr.ForeColor = System.Drawing.SystemColors.Window;
            this.Txtcontr.Location = new System.Drawing.Point(12, 26);
            this.Txtcontr.Name = "Txtcontr";
            this.Txtcontr.PasswordChar = '*';
            this.Txtcontr.Size = new System.Drawing.Size(218, 20);
            this.Txtcontr.TabIndex = 5;
            // 
            // Btnacep
            // 
            this.Btnacep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btnacep.FlatAppearance.BorderSize = 0;
            this.Btnacep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnacep.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnacep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(109)))));
            this.Btnacep.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btnacep.Location = new System.Drawing.Point(124, 367);
            this.Btnacep.Name = "Btnacep";
            this.Btnacep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Btnacep.Size = new System.Drawing.Size(133, 38);
            this.Btnacep.TabIndex = 6;
            this.Btnacep.Text = "IniciarSesion Sesión";
            this.Btnacep.UseVisualStyleBackColor = false;
            this.Btnacep.Click += new System.EventHandler(this.Btnacep_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(109)))));
            this.groupBox1.Controls.Add(this.Txtcontr);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(67, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contraseña:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(109)))));
            this.groupBox2.Controls.Add(this.Txtusu);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(67, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoCS.Properties.Resources.software_security;
            this.pictureBox1.Location = new System.Drawing.Point(96, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::ProyectoCS.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btnacep);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox Txtusu;
        private System.Windows.Forms.TextBox Txtcontr;
        private System.Windows.Forms.Button Btnacep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

