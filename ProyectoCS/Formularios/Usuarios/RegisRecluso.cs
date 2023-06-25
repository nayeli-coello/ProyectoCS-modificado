using ProyectoCS.Datos;
using ProyectoCS.Control;
using System;
using System.Windows.Forms;

namespace ProyectoCS.Formularios.Usuarios
{
    /// <summary>
    /// Formulario de registro de reclusos.
    /// </summary>
    public partial class RegisRecluso : Form
    {
        readonly Validaciones _val = new Validaciones();
        readonly Recluso _re = new Recluso();

        /// <summary>
        /// Constructor de la clase RegisRecluso.
        /// </summary>
        public RegisRecluso()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento de clic en el botón "LblRegr" para regresar al formulario anterior.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmUsuarios FrmUsu = new FrmUsuarios();
            FrmUsu.Show();
            this.Close();
        }


        /// <summary>
        /// Evento de clic en el botón "Btnguardar" para guardar la información del formulario.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            string Nombre = Txtnom.Text;
            string Apellido = Txtape.Text;
            string Cedula = Txtced.Text;
            string FechaNac = Dtpnac.Text;
            string Condena = Txtcond.Text;
            string Expediente = Txtexp.Text;
            
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) || string.IsNullOrEmpty(Cedula) || string.IsNullOrEmpty(Condena) || string.IsNullOrEmpty(Expediente))
            {
                MessageBox.Show(@"Por favor llenar todos los campos....", @"Sistema");

            }
            else
            {
                _re.DatosRecluso(Nombre, Apellido, Cedula, FechaNac, Condena, Expediente);

            }
            
            Limpiar();
        }

        /// <summary>
        /// Evento de clic en el botón "Btncancelar" para cancelar la acción.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void Limpiar()
        {
            Txtnom.Clear();
            Txtape.Clear();
            Txtced.Clear();
            Txtcond.Clear();
            Txtexp.Clear();
        }

        /// <summary>
        /// Evento KeyPress del campo de texto "Txtced" para permitir solo números.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Txtced_KeyPress(object sender, KeyPressEventArgs e)
        {
            _val.SoloNumeros(e);
        }

        /// <summary>
        /// Evento KeyPress del campo de texto "Txtnom" para permitir solo letras.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {
            _val.SoloTexto(e);
        }
    }
}
