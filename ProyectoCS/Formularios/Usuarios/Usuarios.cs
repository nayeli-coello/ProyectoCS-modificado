using ProyectoCS.Formularios.Actividades;
using ProyectoCS.Formularios.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCS.Formularios.Usuarios
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        //Cerramos sesion de la applicacion 
        private void LblCerrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Seguro que desea cerrar sesión?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                FrmLogin FrmLogin = new FrmLogin();
                FrmLogin.Show();
                this.Close();
            }
        }
        //Llamamos a los distintos formularios
        private void Btnact_Click(object sender, EventArgs e)
        {
            FrmActividades FrmAct = new FrmActividades();
            FrmAct.Show();
            this.Close();
        }
        private void Btngen_Click(object sender, EventArgs e)
        {
            FrmGeneral FrmGene = new FrmGeneral();
            FrmGene.Show();
            this.Close();
        }

        private void Lblnuerec_Click(object sender, EventArgs e)
        {
            RegisRecluso RRecl = new RegisRecluso();
            RRecl.Show();
            this.Close();
        }

        private void Lblmodrecl_Click(object sender, EventArgs e)
        {
            ModRecluso MRecl = new ModRecluso();
            MRecl.Show();
            this.Close();
        }

        private void Lblnuerepr_Click(object sender, EventArgs e)
        {
            RegisRepresentante RRepr = new RegisRepresentante();
            RRepr.Show();
            this.Close();
        }

        private void Lblmodrepr_Click(object sender, EventArgs e)
        {
            ModRepresentante MRepr = new ModRepresentante();
            MRepr.Show();
            this.Close();
        }

        private void Lblvinfo_Click(object sender, EventArgs e)
        {
            Consultar Eli = new Consultar();
            Eli.Show();
            this.Close();
        }
    }
}
