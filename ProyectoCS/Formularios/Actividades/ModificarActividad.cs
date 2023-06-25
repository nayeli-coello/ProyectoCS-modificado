using ProyectoCS.Datos;
using System;
using System.Windows.Forms;

namespace ProyectoCS.Formularios.Actividades
{
    /// <summary>
    /// Formulario de modificación de actividad.
    /// </summary>
    public partial class ModificarActividad : Form
    {
        Actividad _act = new Actividad();

        /// <summary>
        /// Constructor de la clase ModificarActividad.
        /// </summary>
        public ModificarActividad()
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
            FrmActividades FrmAct = new FrmActividades();
            FrmAct.Show();
            this.Close();
        }

        /// <summary>
        /// Evento de clic en el botón "CmbRepr" para llenar el combo box "CmbRepr".
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void CmbRepr_Click(object sender, EventArgs e)
        {
            CmbRepr.Items.Clear();
            _act.LlenarCombo(CmbRepr);
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void Limpiar()
        {
            Txtbusc.Clear();
            Txtnomact.Clear();
            Txtval.Clear();
            Txtdias.Clear();
            Txthora.Clear();
            Txtcup.Clear();
            Txtbusc.Enabled = true;
            CmbRepr.SelectedIndex = -1;
            Cmbtip.SelectedIndex = -1;
        }
/*
        private void Cmbtip_Click(object sender, EventArgs e)
        {
             Cmbtip.Items.Clear();
             string[] items = { "Manualidades", "Agricultura", "Deportivo", "Cocinero", "Conserje", "Lavanderia", "Taller de escritura", "Clases de teatro" };
             Cmbtip.Items.AddRange(items);
        }
*/

        /// <summary>
        /// Evento de clic en el botón "BtnCancelar" para limpiar los campos del formulario.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Evento de clic en el botón "BtnBuscar" para buscar una actividad.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Txtbusc.Enabled = false;
            _act.Buscar_Actividad(Txtbusc, Txtnomact, Txtval, Cmbtip, Txtdias, CmbRepr, Txthora, Txtcup);
        }

        /// <summary>
        /// Evento de clic en el botón "BtnModificar" para modificar una actividad.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            _act.Modificar_Actividad(Txtbusc, Txtnomact, Txtval, Cmbtip, Txtdias, CmbRepr, Txthora, Txtcup);
            Limpiar();
        }
    }
}
