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
using System.Xml.Linq;

namespace ProyectoCS.Formularios.Usuarios
{
    public partial class ModRepresentante : Form
    {
        Representante Rep = new Representante();
        public ModRepresentante()
        {
            InitializeComponent();
        }
        //Regresamos al formulatio anterior
        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmUsuarios FrmUsu = new FrmUsuarios();
            FrmUsu.Show();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnModficar_Click(object sender, EventArgs e)
        {
            Rep.ActulizarRepr(TxtBusc, Txtnom, Txtape, Txtfech, Txtesp);
            Limpiar();
        }
        private void Limpiar()
        {
            Txtnom.Text = "";
            Txtape.Text = "";
            Txtfech.Text = "";
            Txtesp.Text = "";
            TxtBusc.Text = "";
            TxtBusc.Enabled = true;

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            TxtBusc.Enabled = false;
            Rep.BuscarEdiRepr(TxtBusc, Txtnom, Txtape, Txtfech, Txtesp);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
