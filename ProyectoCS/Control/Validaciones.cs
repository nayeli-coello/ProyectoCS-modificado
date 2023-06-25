using System.Windows.Forms;

namespace ProyectoCS.Control
{
    public class Validaciones
    {
        public void SoloNumeros(KeyPressEventArgs e) {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)) {
                MessageBox.Show(@"Ingrese solo números", @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public void SoloTexto(KeyPressEventArgs e) {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255)) {
                MessageBox.Show(@"Solo se permiten letras...", @"Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }
    }
}
