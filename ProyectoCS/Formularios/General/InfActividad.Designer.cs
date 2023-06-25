namespace ProyectoCS.Formularios.General
{
    partial class InfActividad
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
            this.ReportActiv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.LblRegr = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 33;
            this.label1.Text = "Informe de  actividades";
            // 
            // ReportActiv
            // 
            this.ReportActiv.LocalReport.ReportEmbeddedResource = "ProyectoCS.Reportes.Actividades.rdlc";
            this.ReportActiv.Location = new System.Drawing.Point(12, 75);
            this.ReportActiv.Name = "ReportActiv";
            this.ReportActiv.ServerReport.BearerToken = null;
            this.ReportActiv.Size = new System.Drawing.Size(776, 356);
            this.ReportActiv.TabIndex = 38;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.pictureBox5.Image = global::ProyectoCS.Properties.Resources._93073;
            this.pictureBox5.Location = new System.Drawing.Point(250, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 29);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 81;
            this.pictureBox5.TabStop = false;
            // 
            // LblRegr
            // 
            this.LblRegr.AutoSize = true;
            this.LblRegr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.LblRegr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRegr.Location = new System.Drawing.Point(722, 30);
            this.LblRegr.Name = "LblRegr";
            this.LblRegr.Size = new System.Drawing.Size(66, 15);
            this.LblRegr.TabIndex = 90;
            this.LblRegr.Text = "Regresar";
            this.LblRegr.Click += new System.EventHandler(this.LblRegr_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.pictureBox4.Image = global::ProyectoCS.Properties.Resources._1174444;
            this.pictureBox4.Location = new System.Drawing.Point(686, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 89;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.LblRegr_Click);
            // 
            // InfActividad
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ProyectoCS.Properties.Resources.FondoReportes;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LblRegr);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.ReportActiv);
            this.Controls.Add(this.label1);
            this.Name = "InfActividad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informe de Actividad";
            this.Load += new System.EventHandler(this.InfActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer ReportActiv;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label LblRegr;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}