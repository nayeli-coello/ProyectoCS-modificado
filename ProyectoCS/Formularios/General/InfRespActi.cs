using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using MySql.Data.MySqlClient;
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
    public partial class InfRespActi : Form
    {
        Informes Inf = new Informes();
        public InfRespActi()
        {
            InitializeComponent();
            Inf.ReportRepresentante(ReportRepres);
        }

        //Regresamos al formulatio anterior
        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmGeneral FrmGene = new FrmGeneral();
            FrmGene.Show();
            this.Close();
        }

        private void InfRespActi_Load(object sender, EventArgs e)
        {

            this.ReportRepres.RefreshReport();
        }

    }
}
