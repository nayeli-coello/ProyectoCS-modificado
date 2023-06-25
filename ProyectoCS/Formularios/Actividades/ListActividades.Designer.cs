namespace ProyectoCS.Formularios.Actividades
{
    partial class ListActividades
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
            this.LstvActividades = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomAct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValAct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipAct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepresAct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.LblRegr = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LstvActividades
            // 
            this.LstvActividades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.NomAct,
            this.ValAct,
            this.TipAct,
            this.RepresAct});
            this.LstvActividades.HideSelection = false;
            this.LstvActividades.Location = new System.Drawing.Point(64, 150);
            this.LstvActividades.Name = "LstvActividades";
            this.LstvActividades.Size = new System.Drawing.Size(534, 203);
            this.LstvActividades.TabIndex = 0;
            this.LstvActividades.UseCompatibleStateImageBehavior = false;
            this.LstvActividades.View = System.Windows.Forms.View.Details;
            // 
            // Id
            // 
            this.Id.Text = "Id Actividad";
            this.Id.Width = 87;
            // 
            // NomAct
            // 
            this.NomAct.Text = "Nombre";
            this.NomAct.Width = 116;
            // 
            // ValAct
            // 
            this.ValAct.Text = "Valor";
            this.ValAct.Width = 84;
            // 
            // TipAct
            // 
            this.TipAct.Text = "Tipo";
            this.TipAct.Width = 100;
            // 
            // RepresAct
            // 
            this.RepresAct.Text = "Representante";
            this.RepresAct.Width = 142;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(235, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lista de Actividades";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(61, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Buscar Id de la Actividad:";
            // 
            // Txtid
            // 
            this.Txtid.Location = new System.Drawing.Point(195, 113);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(177, 20);
            this.Txtid.TabIndex = 30;
            // 
            // LblRegr
            // 
            this.LblRegr.AutoSize = true;
            this.LblRegr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.LblRegr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRegr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRegr.Location = new System.Drawing.Point(579, 25);
            this.LblRegr.Name = "LblRegr";
            this.LblRegr.Size = new System.Drawing.Size(66, 15);
            this.LblRegr.TabIndex = 34;
            this.LblRegr.Text = "Regresar";
            this.LblRegr.Click += new System.EventHandler(this.LblRegr_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.pictureBox4.Image = global::ProyectoCS.Properties.Resources._1174444;
            this.pictureBox4.Location = new System.Drawing.Point(543, 21);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 74;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.LblRegr_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnBuscar.Image = global::ProyectoCS.Properties.Resources._1071221;
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(481, 107);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(117, 36);
            this.BtnBuscar.TabIndex = 75;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Image = global::ProyectoCS.Properties.Resources._1295656;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // ListActividades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ProyectoCS.Properties.Resources.fondoforms2;
            this.ClientSize = new System.Drawing.Size(670, 395);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.LblRegr);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstvActividades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListActividades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Actividades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LstvActividades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader NomAct;
        private System.Windows.Forms.ColumnHeader ValAct;
        private System.Windows.Forms.ColumnHeader TipAct;
        private System.Windows.Forms.ColumnHeader RepresAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.Label LblRegr;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}