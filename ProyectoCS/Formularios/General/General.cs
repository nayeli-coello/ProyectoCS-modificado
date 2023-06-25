using ProyectoCS.Formularios.Actividades;
using ProyectoCS.Formularios.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCS.Formularios.General
{
    public partial class FrmGeneral : Form
    {
        public FrmGeneral()
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

        private void Btnusu_Click(object sender, EventArgs e)
        {
            FrmUsuarios FrmUsu = new FrmUsuarios();
            FrmUsu.Show();
            this.Close();
        }

        private void Lblinfrecl_Click(object sender, EventArgs e)
        {
            InfActividad Icond = new InfActividad();
            Icond.Show();
            this.Close();
        }

        private void Lblinfcond_Click(object sender, EventArgs e)
        {
            InfRecluso Irecl = new InfRecluso();
            Irecl.Show();
            this.Close();
        }

        private void Lblinfresp_Click(object sender, EventArgs e)
        {
            InfRespActi Iresp = new InfRespActi();
            Iresp.Show();
            this.Close();
        }
    }
}
