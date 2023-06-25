using ProyectoCS.Datos;
using System;
using System.Windows.Forms;

namespace ProyectoCS.Formularios.Actividades
{
    public partial class LisInscrip : Form
    {
        readonly Actividad _act = new Actividad();
        public LisInscrip()
        {
            InitializeComponent();
            _act.LLenarAct1(Listact);
        }

        private void LblRegr_Click(object sender, EventArgs e)
        {
            FrmActividades FrmAct = new FrmActividades();
            FrmAct.Show();
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            String Tipo = Cmbtipo.Text;
            _act.LLenarAct2(Listact, Tipo);
        }

        private void Cmbtipo_Click(object sender, EventArgs e)
        {
            Cmbtipo.Items.Clear();
            _act.LlenarComboActividad(Cmbtipo);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Cmbtipo.Text = @" ";
            _act.LLenarAct1(Listact);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmActividades FrmAct = new FrmActividades();
            FrmAct.Show();
            this.Close();
        }
    }
}
