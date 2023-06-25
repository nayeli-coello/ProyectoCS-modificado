using ProyectoCS.Datos;
using System;
using System.Windows.Forms;

namespace ProyectoCS.Formularios.Actividades
{
    /// <summary>
    /// Formulario de inscripciones a actividades.
    /// </summary>
    public partial class Inscripciones : Form
    {
        readonly Actividad _act = new Actividad();
        readonly Recluso _re = new Recluso();

        /// <summary>
        /// Constructor de la clase Inscripciones.
        /// </summary>
        public Inscripciones()
        {
            InitializeComponent();
            TxtNom.Enabled = false;
            TxtApe.Enabled = false;
            Txtdias.Enabled = false;
            Txthora.Enabled = false;
            GrbPena.Visible = false;
        }

        /// <summary>
        /// Evento de clic en el botón "LblRegr" para regresar al formulario anterior.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmActividades FrmAct = new FrmActividades();
            FrmAct.Show();
            this.Close();
        }

        /// <summary>
        /// Evento de clic en el botón "Cmbtip" para llenar el combo box "Cmbtip" con las actividades.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Cmbtip_Click(object sender, EventArgs e)
        {
            Cmbtip.Items.Clear();
            _act.LlenarComboActividad(Cmbtip);
        }

        /// <summary>
        /// Evento que se activa cuando se selecciona una actividad en el combo box "Cmbtip".
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Cmbtip_SelectedIndexChanged(object sender, EventArgs e)
        {
            _act.LlenarHorario(Cmbtip, Txtdias, Txthora);
        }

        /// <summary>
        /// Evento de clic en el botón "BtnFuga" para manejar la situación de fuga de un recluso.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnFuga_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, @"El recluso cometió alguna infracción?", @"Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Cmbtip.Text = "";
                Txtdias.Text = "";
                Txthora.Text = "";
                Cmbtip.Enabled = false;
                GrbPena.Visible = true;
            }
            else if(dr == DialogResult.No){
                Cmbtip.Enabled = true;
                Cmbtip.Text = "";
                GrbPena.Visible = false;
            }
        }

        /// <summary>
        /// Evento de clic en el botón "BtnGuardar" para guardar la inscripción a una actividad.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (GrbPena.Visible)
            {
                String fecha = DateTime.Now.ToLongDateString();
                _act.Fuga(Txtced, TxtNom, TxtApe, fecha, TxtMot);
                _re.Fuga(Txtced, TxtValor);
            }
            else
            {
                _act.BuscCupos(Cmbtip);
                _act.AgreRecAct(TxtNom, TxtApe, Txtced, Cmbtip, Txtdias, Txthora);
            }
            Visualización();
        }

        /// <summary>
        /// Evento que se activa cuando se cambia el texto en el cuadro de texto "Txtced".
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Txtced_TextChanged(object sender, EventArgs e)
        {
            if (Txtced.Text.Length.ToString()== "10")
            {
                _re.BuscarRec(Txtced, TxtNom, TxtApe);
            }
            
        }

        /// <summary>
        /// Evento de clic en la imagen "pictureBox4" para regresar al formulario anterior.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmActividades FrmAct = new FrmActividades();
            FrmAct.Show();
            this.Close();
        }

        /// <summary>
        /// Evento de clic en el botón "BtnCancelar" para restablecer la visualización del formulario.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Visualización();
        }

        /// <summary>
        /// Restablece la visualización del formulario.
        /// </summary>
        private void Visualización()
        {
            Cmbtip.Enabled = true;
            Cmbtip.Text = "";
            TxtNom.Text = "";
            TxtApe.Text = "";
            Txtced.Text = "";
            Txtdias.Text = "";
            Txthora.Text = "";
            TxtValor.Text = "";
            TxtMot.Text = "";
            GrbPena.Visible = false;
        }
    }
}
