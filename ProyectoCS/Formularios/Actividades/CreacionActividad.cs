using ProyectoCS.Datos;
using System;
using System.Windows.Forms;


namespace ProyectoCS.Formularios.Actividades
{
    /// <summary>
    /// Formulario de creación de actividad.
    /// </summary>
    public partial class CreacionActividad : Form
    {
        Actividad _act = new Actividad();

        /// <summary>
        /// Constructor de la clase CreacionActividad.
        /// </summary>
        public CreacionActividad()
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
        /// Evento de clic en el botón "BtnGuardar" para guardar la información de la actividad.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Id = txtidact.Text;
            string Nombre = Txtnomact.Text;
            string Valor = Txtval.Text;
            string Tipo = Cmbtip.Text;
            string Dias = Txtdias.Text;
            string Representante = CmbRepr.Text;
            string Hora = Txthora.Text;
            string Cupos = Txtcup.Text;
            if (string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Valor) || string.IsNullOrEmpty(Tipo) || string.IsNullOrEmpty(Dias) || 
                string.IsNullOrEmpty(Representante) || string.IsNullOrEmpty(Hora) || string.IsNullOrEmpty(Cupos))
            {
                MessageBox.Show(@"Por favor llenar todos los campos....", @"Sistema");

            }
            else
            {
                _act.CreacionActividad(Id, Nombre, Valor, Tipo, Dias, Representante, Hora, Cupos);
                Limpiar();

            }
            
        }

        /// <summary>
        /// Limpia los campos del formulario.
        /// </summary>
        private void Limpiar()
        {
            txtidact.Clear();
            Txtnomact.Clear();
            Txtval.Clear();
            Txtdias.Clear();
            Txthora.Clear();
            Txtcup.Clear();
            CmbRepr.SelectedIndex = -1;
            Cmbtip.SelectedIndex = -1;
        }

        /// <summary>
        /// Evento de clic en el botón "Cmbtip" para llenar el combo box "Cmbtip" con opciones predefinidas.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void Cmbtip_Click(object sender, EventArgs e)
        {
            Cmbtip.Items.Clear();
            object[] items = { "Manualidades", "Agricultura", "Deportivo", "Cocinero", "Conserje", "Lavanderia", "Taller de escritura", "Clases de teatro" };
            Cmbtip.Items.AddRange(items);
        }

        /// <summary>
        /// Evento de clic en el botón "BtnCancelar" para limpiar los campos del formulario.
        /// </summary>
        /// <param name="sender">Objeto que generó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
