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
    public partial class RegisRepresentante : Form
    {
        Representante Rep = new Representante();
        public RegisRepresentante()
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

        //Guarda la información del formulario
        private void Btnguardar_Click(object sender, EventArgs e)
        {

            string Nombre = Txtnom.Text;
            string Apellido = Txtape.Text;
            string Cedula = Txtced.Text;
            string FechaNac = Dtpnac.Text;
            string Especialidad = Txtesp.Text;
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) || string.IsNullOrEmpty(Cedula) || string.IsNullOrEmpty(Especialidad))
            {
                MessageBox.Show("Por favor llenar todos los campos....", "Sistema");

            }
            else
            {
                Rep.DatosRepresentante(Nombre, Apellido, Cedula, FechaNac, Especialidad);
                limpiar();
            }
            
        }

        //Cancela la acción
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void limpiar()
        {
            Txtnom.Clear();
            Txtape.Clear();
            Txtced.Clear();
            Txtesp.Clear();
        }
    }
}
