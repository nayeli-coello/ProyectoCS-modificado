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
    public partial class InfActividad : Form
    {
        Informes Inf = new Informes();
        public InfActividad()
        {
            InitializeComponent();
            Inf.ReportActividades(ReportActiv);
        }
        //Regresamos al formulatio anterior
        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmGeneral FrmGene = new FrmGeneral();
            FrmGene.Show();
            this.Close();
        }

        private void InfActividad_Load(object sender, EventArgs e)
        {

            this.ReportActiv.RefreshReport();
        }
    }
}
