using ProyectoCS.Datos;
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
    public partial class InfRecluso : Form
    {
        Informes Inf = new Informes();
        public InfRecluso()
        {
            InitializeComponent();
            Inf.ReportRecluso(ReportRecluso);
        }
        //Regresamos al formulatio anterior
        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmGeneral FrmGene = new FrmGeneral();
            FrmGene.Show();
            this.Close();
        }

        private void InfRecluso_Load(object sender, EventArgs e)
        {

            this.ReportRecluso.RefreshReport();
        }
    }
}
