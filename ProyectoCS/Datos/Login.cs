using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoCS.Formularios.Actividades;
using CommandType = System.Data.CommandType;

namespace ProyectoCS.Datos
{
    /// <summary>
    /// Clase utilizada para el inicio de sesión y autenticación de usuarios.
    /// </summary>
    public class Login :DbContext {
        /// <summary>
        /// Intenta iniciar sesión con las credenciales de usuario proporcionadas.
        /// </summary>
        /// <param name="usuario">El nombre de usuario.</param>
        /// <param name="clave">La clave de acceso.</param>
        /// <returns>True si el inicio de sesión es exitoso, false en caso contrario.</returns>
        public bool IniciarSesion(string usuario, string clave) {

            var frmAct = new FrmActividades();

            try {
                ConnectionBd.Open();
                Command.Connection = ConnectionBd;
                Command.CommandText = "INICIAR";
                Command.CommandType = (CommandType)Microsoft.ReportingServices.DataProcessing.CommandType.StoredProcedure;
                //Mandamos esta linea a la aplicacion de MySQL para traer los datos que estamos requiriendo 
                Command.Parameters.AddWithValue("@usu", usuario);
                Command.Parameters.AddWithValue("@cla", clave);
                Command.ExecuteNonQuery();
                //Verifica si con la coincidencia se encontro 
                var reader = Command.ExecuteReader();
                while (reader.Read()) {
                    if (Convert.ToString(reader["Nombre_de_usu"]) != usuario ||
                        Convert.ToString(reader["Clave"]) != clave) {
                        continue;
                    }
                    MessageBox.Show(@"Inicio de sesión exitosa...", @"Conectado");
                    //Se abre el formulario 
                    frmAct.Show();
                    return true;
                }
            }
            catch (MySqlException ex) {
                MessageBox.Show("" + ex);
                return false;
            }
            finally {
                Command.Parameters.Clear();
                ConnectionBd.Close();
            }

            return false;
        }
    }
}
