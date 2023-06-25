using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoCS.Excepciones;

namespace ProyectoCS.Datos
{
    public class Representante : DbContext
    {
        /// <summary>
        /// Agrega un representante a la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del representante.</param>
        /// <param name="apellido">Apellido del representante.</param>
        /// <param name="cedula">Cédula del representante.</param>
        /// <param name="fechaNac">Fecha de nacimiento del representante.</param>
        /// <param name="especialidad">Especialidad del representante.</param>
        internal void DatosRepresentante(string nombre, string apellido, string cedula, string fechaNac, string especialidad)
        {
            try
            {
                ConnectionBd.Open();
                //Se manda los datos del representante que fueron ingresados a la base de datos para que puedan ser guardados
                Command.Connection = ConnectionBd;
                Command.CommandText = "DREPRESENTANTE";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@ape", apellido);
                Command.Parameters.AddWithValue("@ced", cedula);
                Command.Parameters.AddWithValue("@fec", fechaNac);
                Command.Parameters.AddWithValue("@esp", especialidad);
                Command.ExecuteNonQuery();
                MessageBox.Show(@"Representante Registrado...");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                Command.Parameters.Clear();
                ConnectionBd.Close();
            }
        }

        /// <summary>
        /// Busca un representante en la base de datos y muestra sus datos en los campos correspondientes.
        /// </summary>
        /// <param name="txtBusc">Cuadro de texto que contiene la cédula del representante a buscar.</param>
        /// <param name="txtnom">Cuadro de texto donde se muestra el nombre del representante encontrado.</param>
        /// <param name="txtape">Cuadro de texto donde se muestra el apellido del representante encontrado.</param>
        /// <param name="txtfech">Cuadro de texto donde se muestra la fecha de nacimiento del representante encontrado.</param>
        /// <param name="txtesp">Cuadro de texto donde se muestra la especialidad del representante encontrado.</param>
        internal void BuscarEdiRepr(TextBox txtBusc, TextBox txtnom, TextBox txtape, TextBox txtfech, TextBox txtesp)
        {
            try
            {
                ConnectionBd.Open();
                string buscar = txtBusc.Text;
                Command.Connection = ConnectionBd;
                Command.CommandText = "BUSCREPRESENTANTE";
                Command.CommandType = CommandType.StoredProcedure;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Parameters.AddWithValue("@busc", buscar);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        //Se llenan los Txt para poder modificarlos
                        txtnom.Text = Reader.GetString(0);
                        txtape.Text = Reader.GetString(1);
                        txtfech.Text = Reader.GetString(3);
                        txtesp.Text = Reader.GetString(4);
                    }
                }
                else
                {
                    throw new ExceptionRepresentante();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ExceptionRepresentante)
            {
                txtBusc.Enabled = true;
            }
            finally
            {
                Command.Parameters.Clear();
                Reader.Close();
                ConnectionBd.Close();
            }
        }

        /// <summary>
        /// Actualiza los datos de un representante en la base de datos.
        /// </summary>
        /// <param name="txtBusc">Cuadro de texto que contiene la cédula del representante a actualizar.</param>
        /// <param name="txtnom">Cuadro de texto que contiene el nuevo nombre del representante.</param>
        /// <param name="txtape">Cuadro de texto que contiene el nuevo apellido del representante.</param>
        /// <param name="txtfech">Cuadro de texto que contiene la nueva fecha de nacimiento del representante.</param>
        /// <param name="txtesp">Cuadro de texto que contiene la nueva especialidad del representante.</param>
        internal void ActulizarRepr(TextBox txtBusc, TextBox txtnom, TextBox txtape, TextBox txtfech, TextBox txtesp)
        {
            string cedula = txtBusc.Text;
            string nombre = txtnom.Text;
            string apellido = txtape.Text;
            string fechaNac = txtfech.Text;
            string expediente = txtesp.Text;

            try
            {
                Command.Connection = ConnectionBd;
                Command.CommandText = "ACTUREPRESENTANTE";
                Command.CommandType = CommandType.StoredProcedure;
                //Mandamamos los datos modificados a la base de datos para que se pueda actualizar con la condicion que le mandamos
                Command.Parameters.AddWithValue("@bus", cedula);
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@ape", apellido);
                Command.Parameters.AddWithValue("@fech", fechaNac);
                Command.Parameters.AddWithValue("@esp", expediente);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();

                MessageBox.Show(@"Representante Actualizado...");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                Command.Parameters.Clear();
                ConnectionBd.Close();
            }
        }
    }
}
