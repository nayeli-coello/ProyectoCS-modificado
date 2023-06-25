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

namespace ProyectoCS.Formularios.Usuarios
{
    public partial class ModRecluso : Form
    {
        Recluso Re = new Recluso();
        public ModRecluso()
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

        private void Btnbusc_Click(object sender, EventArgs e)
        {
            TxtBusc.Enabled = false;
            Re.BuscarEdiRecl(TxtBusc,Txtnom, Txtape, Txtfech, Txtcond, Txtexp);
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            Re.ActulizarRecl(TxtBusc,Txtnom, Txtape, Txtfech, Txtcond, Txtexp);
            Limpiar();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            Txtnom.Text = "";
            Txtape.Text = "";
            Txtfech.Text = "";
            Txtcond.Text = "";
            Txtexp.Text = "";
            TxtBusc.Text = "";
            TxtBusc.Enabled = true;

        }


    }
}
