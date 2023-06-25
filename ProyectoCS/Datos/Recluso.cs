using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoCS.Excepciones;

namespace ProyectoCS.Datos
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con los reclusos en la base de datos.
    /// </summary>
    public class Recluso : DbContext
    {
        /// <summary>
        /// Agrega un nuevo recluso a la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del recluso.</param>
        /// <param name="apellido">Apellido del recluso.</param>
        /// <param name="cedula">Cédula del recluso.</param>
        /// <param name="fechaNac">Fecha de nacimiento del recluso.</param>
        /// <param name="condena">Condena del recluso.</param>
        /// <param name="expediente">Expediente del recluso.</param>
        internal void DatosRecluso(string nombre, string apellido, string cedula, string fechaNac, string condena, string expediente)
        {
            try
            {
                ConnectionBd.Open();
                //Se manda los datos del recluso que fueron ingresados a la base de datos para que puedan ser guardados
                Command.Connection = ConnectionBd;
                Command.CommandText = "DRECLUSO";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@ape", apellido);
                Command.Parameters.AddWithValue("@ced", cedula);
                Command.Parameters.AddWithValue("@fec", fechaNac);
                Command.Parameters.AddWithValue("@con", condena);
                Command.Parameters.AddWithValue("@exp", expediente);
                Command.ExecuteNonQuery();
                MessageBox.Show(@"Recluso Registrado...");

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
        /// Busca un recluso en la base de datos y muestra sus datos en los campos correspondientes.
        /// </summary>
        /// <param name="txtBusc">Cuadro de texto que contiene la cédula del recluso a buscar.</param>
        /// <param name="txtnom">Cuadro de texto donde se muestra el nombre del recluso encontrado.</param>
        /// <param name="txtape">Cuadro de texto donde se muestra el apellido del recluso encontrado.</param>
        /// <param name="txtfech">Cuadro de texto donde se muestra la fecha de nacimiento del recluso encontrado.</param>
        /// <param name="txtcond">Cuadro de texto donde se muestra la condena del recluso encontrado.</param>
        /// <param name="txtexp">Cuadro de texto donde se muestra el expediente del recluso encontrado.</param>
        internal void BuscarEdiRecl(TextBox txtBusc, TextBox txtnom, TextBox txtape, TextBox txtfech, TextBox txtcond, TextBox txtexp)
        {
            try
            {
                ConnectionBd.Open();
                string busc = txtBusc.Text;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "BUSCRECLUSO";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@busc", busc);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        //Se llenan los Txt para poder modificarlos
                        txtnom.Text = Reader.GetString(0);
                        txtape.Text = Reader.GetString(1);
                        txtfech.Text = Reader.GetString(2);
                        txtcond.Text = Reader.GetString(3);
                        txtexp.Text = Reader.GetString(4);
                    }
                }
                else
                {
                    throw new ExceptionRecluso();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ExceptionRecluso)
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
        /// Actualiza los datos de un recluso en la base de datos.
        /// </summary>
        /// <param name="txtbusc">Cuadro de texto que contiene la cédula del recluso a actualizar.</param>
        /// <param name="txtnom">Cuadro de texto que contiene el nuevo nombre del recluso.</param>
        /// <param name="txtape">Cuadro de texto que contiene el nuevo apellido del recluso.</param>
        /// <param name="txtfech">Cuadro de texto que contiene la nueva fecha de nacimiento del recluso.</param>
        /// <param name="txtcond">Cuadro de texto que contiene la nueva condena del recluso.</param>
        /// <param name="txtexp">Cuadro de texto que contiene el nuevo expediente del recluso.</param>
        internal void ActulizarRecl(TextBox txtbusc, TextBox txtnom, TextBox txtape, TextBox txtfech, TextBox txtcond, TextBox txtexp)
        {
            string cedula = txtbusc.Text;
            string nombre = txtnom.Text;
            string apellido = txtape.Text;
            string fecha = txtfech.Text;
            string condena = txtcond.Text;
            string expediente = txtexp.Text;

            try
            {
                //Mandamamos los datos modificados a la base de datos para que se pueda actualizar con la condicion que le mandamos
                Command.Connection = ConnectionBd;
                Command.CommandText = "ACTURECLUSO";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", cedula);
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@ape", apellido);
                Command.Parameters.AddWithValue("@fec", fecha);
                Command.Parameters.AddWithValue("@con", condena);
                Command.Parameters.AddWithValue("@exp", expediente);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();


                MessageBox.Show(@"Recluso Actualizado...");

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
        /// Busca un recluso en la base de datos y muestra su nombre y apellido en los campos correspondientes.
        /// </summary>
        /// <param name="txtced">Cuadro de texto que contiene la cédula del recluso a buscar.</param>
        /// <param name="txtNom">Cuadro de texto donde se muestra el nombre del recluso encontrado.</param>
        /// <param name="txtApe">Cuadro de texto donde se muestra el apellido del recluso encontrado.</param>
        internal void BuscarRec(TextBox txtced, TextBox txtNom, TextBox txtApe)
        {
            try
            {
                ConnectionBd.Open();
                string buscar = txtced.Text;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "RECCED";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", buscar);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        //Se llenan los Txt para poder modificarlos
                        txtNom.Text = Reader.GetString(0);
                        txtApe.Text = Reader.GetString(1);
                    }
                }
                else
                {
                    throw new ExceptionRecluso();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ExceptionRecluso)
            {
                txtced.Enabled = true;
            }
            finally
            {
                Command.Parameters.Clear();
                Reader.Close();
                ConnectionBd.Close();
            }
        }

        /// <summary>
        /// Actualiza el número de días de fuga de un recluso en la base de datos.
        /// </summary>
        /// <param name="txtced">Cuadro de texto que contiene la cédula del recluso fugado.</param>
        /// <param name="txtvalor">Cuadro de texto que contiene el valor a sumar a los días de fuga del recluso.</param>
        internal void Fuga(TextBox txtced, TextBox txtvalor)
        {
            int dia = 0;
            int valor = Int32.Parse(txtvalor.Text);
            try
            {
                ConnectionBd.Open();
                string busc = txtced.Text;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "TabRecluso";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", busc);
                Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        dia = Int32.Parse(Reader.GetString(4)); 
                    }
                }
                else
                {
                    throw new ExceptionRecluso();


                }

                ActFuga(dia, busc, valor);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ExceptionRecluso)
            {
                txtced.Enabled = true;
            }
            finally
            {
                Reader.Close();
                Command.Parameters.Clear();
            }
        }

        private void ActFuga(int dia, string busc, int valor)
        {
            dia += valor;
            string Dia = dia.ToString();
            try
            {
                ConnectionBd.Close();
                ConnectionBd.Open();
                Command.Parameters.Clear();
                //Mandamamos los datos modificados a la base de datos para que se pueda actualizar con la condicion que le mandamos
                Command.Connection = ConnectionBd;
                Command.CommandText = "ACTFUGA";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", busc);
                Command.Parameters.AddWithValue("@dia", Dia);
                Command.ExecuteNonQuery();
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
