using ProyectoCS.Formularios.General;
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

namespace ProyectoCS.Formularios.Actividades
{
    public partial class FrmActividades : Form
    {
        public FrmActividades()
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
        private void Btngen_Click(object sender, EventArgs e)
        {
            FrmGeneral FrmGene = new FrmGeneral();
            FrmGene.Show();
            this.Close();
        }

        private void Btnusu_Click(object sender, EventArgs e)
        {
            FrmUsuarios FrmUsu = new FrmUsuarios();
            FrmUsu.Show();
            this.Close();
        }

        //Lista las diferentes actividades
        private void LblListActi_Click(object sender, EventArgs e)
        {
            ListActividades Lact = new ListActividades();
            Lact.Show();
            this.Close();
        }

        //Crea actividades
        private void LblCreActi_Click(object sender, EventArgs e)
        {
            CreacionActividad Cact = new CreacionActividad();
            Cact.Show();
            this.Close();
        }

        //Modifica actividades
        private void LblModAct_Click(object sender, EventArgs e)
        {
            ModificarActividad Mact = new ModificarActividad();
            Mact.Show();
            this.Close();
        }

        //Muestras las horas dispuestas a las actividades
        private void LblHorDis_Click(object sender, EventArgs e)
        {
            HorActividades Hact = new HorActividades();
            Hact.Show();
            this.Close();
        }

        private void LblInscrip_Click(object sender, EventArgs e)
        {
            Inscripciones Insc = new Inscripciones();
            Insc.Show();
            this.Close();
        }

        private void LblLisInscrip_Click(object sender, EventArgs e)
        {
            LisInscrip LInscrip = new LisInscrip();
            LInscrip.Show();
            this.Close();
        }
    }
}
