using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoCS.Excepciones;

namespace ProyectoCS.Datos
{
    /// <summary>
    /// Clase que representa una actividad y proporciona métodos para interactuar con la base de datos.
    /// </summary>
    public class Actividad : DbContext
    {
        /// <summary>
        /// Llena un ComboBox con los representantes de actividades.
        /// </summary>
        /// <param name="mycombo">ComboBox a llenar.</param>
        public void LlenarCombo(ComboBox mycombo)
        {
            try
            {
                var dataAdapter = new MySqlDataAdapter();
                var clientds = new DataSet();

                Command.Connection = ConnectionBd;
                Command.CommandText = "REPRESEN";
                Command.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(clientds);
                ConnectionBd.Open();
                Reader = Command.ExecuteReader();
                var clientsTable = clientds.Tables[0];

                try
                {
                    for (int i = 0; i < clientsTable.Rows.Count; i++)
                    {
                        DataRow rowClient = clientsTable.Rows[i];
                        mycombo.Items.Add(rowClient["Representante"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                Command.Parameters.Clear();
                Reader.Close();
                ConnectionBd.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(@" " + ex);
            }
        }

        /// <summary>
        /// Crea una nueva actividad en la base de datos.
        /// </summary>
        /// <param name="id">ID de la actividad.</param>
        /// <param name="nombre">Nombre de la actividad.</param>
        /// <param name="valor">Valor de la actividad.</param>
        /// <param name="tipo">Tipo de la actividad.</param>
        /// <param name="dias">Días de la actividad.</param>
        /// <param name="representante">Representante de la actividad.</param>
        /// <param name="hora">Hora de la actividad.</param>
        /// <param name="cupos">Cupos de la actividad.</param>
        internal void CreacionActividad(string id, string nombre, string valor, string tipo, string dias, string representante, string hora, string cupos)
        {
            try
            {
                Command.Connection = ConnectionBd;
                Command.CommandText = "CREACTIVIDAD";
                Command.CommandType = CommandType.StoredProcedure;
                //Se manda los datos de la actividad que fueron ingresados a la base de datos para que puedan ser guardados
                Command.Parameters.AddWithValue("@id", id);
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@val", valor);
                Command.Parameters.AddWithValue("@tip", tipo);
                Command.Parameters.AddWithValue("@dias", dias);
                Command.Parameters.AddWithValue("@rep", representante);
                Command.Parameters.AddWithValue("@hor", hora);
                Command.Parameters.AddWithValue("@cup", cupos);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show(@"Actividad Creada...");

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
        /// Busca una actividad en la base de datos y muestra sus detalles en los campos correspondientes.
        /// </summary>
        /// <param name="txtbusc">TextBox de búsqueda.</param>
        /// <param name="txtnomact">TextBox para mostrar/ingresar el nombre de la actividad.</param>
        /// <param name="txtval">TextBox para mostrar/ingresar el valor de la actividad.</param>
        /// <param name="cmbtip">ComboBox para mostrar/ingresar el tipo de la actividad.</param>
        /// <param name="txtdias">TextBox para mostrar/ingresar los días de la actividad.</param>
        /// <param name="cmbRepr">ComboBox para mostrar/ingresar el representante de la actividad.</param>
        /// <param name="txthora">TextBox para mostrar/ingresar la hora de la actividad.</param>
        /// <param name="txtcup">TextBox para mostrar/ingresar los cupos de la actividad.</param>
        internal void Buscar_Actividad(TextBox txtbusc, TextBox txtnomact, TextBox txtval, ComboBox cmbtip, TextBox txtdias, ComboBox cmbRepr, TextBox txthora, TextBox txtcup)
        {
            MySqlDataReader reader = null;
            try
            {
                ConnectionBd.Open();
                string busc = txtbusc.Text;
                //Buscamos los datos de la actividad
                Command.Connection = ConnectionBd;
                Command.CommandText = "BUSCACTIVIDAD";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@busc", busc);
                reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Se llenan los Txt para poder modificarlos
                        txtnomact.Text = reader.GetString(1);
                        txtval.Text = reader.GetString(2);
                        cmbtip.Text = reader.GetString(3);
                        cmbRepr.Text = reader.GetString(4);
                        txtdias.Text = reader.GetString(5);
                        txthora.Text = reader.GetString(6);
                        txtcup.Text = reader.GetString(7);
                    }
                }
                else
                {
                    throw new ExceptionActividad();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (ExceptionActividad)
            {
                txtbusc.Enabled = true;
            }
            finally
            {
                Command.Parameters.Clear();
                reader?.Close();
                ConnectionBd.Close();
            }
        }

        /// <summary>
        /// Modifica una actividad existente en la base de datos.
        /// </summary>
        /// <param name="txtbusc">TextBox de búsqueda.</param>
        /// <param name="txtnomact">TextBox para mostrar/ingresar el nombre de la actividad.</param>
        /// <param name="txtval">TextBox para mostrar/ingresar el valor de la actividad.</param>
        /// <param name="cmbtip">ComboBox para mostrar/ingresar el tipo de la actividad.</param>
        /// <param name="txtdias">TextBox para mostrar/ingresar los días de la actividad.</param>
        /// <param name="cmbRepr">ComboBox para mostrar/ingresar el representante de la actividad.</param>
        /// <param name="txthora">TextBox para mostrar/ingresar la hora de la actividad.</param>
        /// <param name="txtcup">TextBox para mostrar/ingresar los cupos de la actividad.</param>
        internal void Modificar_Actividad(TextBox txtbusc, TextBox txtnomact, TextBox txtval, ComboBox cmbtip, TextBox txtdias, ComboBox cmbRepr, TextBox txthora, TextBox txtcup)
        {
            string buscar = txtbusc.Text;
            string nombre = txtnomact.Text;
            string valor = txtval.Text;
            string tipo = cmbtip.Text;
            string dias = txtdias.Text;
            string representante = cmbRepr.Text;
            string hora = txthora.Text;
            string cupo = txtcup.Text;

            try
            {
                Command.Connection = ConnectionBd;
                Command.CommandText = "MODACTIVIDAD";
                Command.CommandType = CommandType.StoredProcedure;
                //Se manda los datos de la actividad que fueron ingresados a la base de datos para que puedan ser guardados
                Command.Parameters.AddWithValue("@bus", buscar);
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@val", valor);
                Command.Parameters.AddWithValue("@tip", tipo);
                Command.Parameters.AddWithValue("@dias", dias);
                Command.Parameters.AddWithValue("@rep", representante);
                Command.Parameters.AddWithValue("@hor", hora);
                Command.Parameters.AddWithValue("@cup", cupo);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show(@"Actividad Actualizada...");

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
        /// Llena el ListView con los horarios de las actividades.
        /// </summary>
        /// <param name="lstvHorario">ListView en el que se mostrarán los horarios.</param>
        internal void Llenar_horario(ListView lstvHorario)
        {
            ConnectionBd.Open();
            Command.Connection = ConnectionBd;
            //Llamamos al procedimiento almacenado
            Command.CommandText = "LLENARHORARIOS";
            Command.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = Command;
            DataSet ds = new DataSet();
            DataTable tabla;
            adap.Fill(ds);
            Command.ExecuteNonQuery();
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["Nombre"].ToString());
                elementos.SubItems.Add(filas["Dia"].ToString());
                elementos.SubItems.Add(filas["Cupo"].ToString());
                elementos.SubItems.Add(filas["Hora"].ToString());
                lstvHorario.Items.Add(elementos);
            }
            Command.Parameters.Clear();
            ConnectionBd.Close();
        }

        /// <summary>
        /// Busca las actividades por ID y las muestra en el ListView.
        /// Si el parámetro "id" está vacío, muestra todas las actividades.
        /// </summary>
        /// <param name="id">ID de la actividad a buscar (opcional).</param>
        /// <param name="lstvActividades">ListView en el que se mostrarán las actividades encontradas.</param>
        internal void Buscar_Actividades(string id, ListView lstvActividades)
        {
            //Si no busca una actividad en especifico
            if (string.IsNullOrEmpty(id))
            {
                llenarlist2_1(lstvActividades);
            }
            else
            {
                //Si busca una actividad en especifico
                Command.Connection = ConnectionBd;
                //Llamamos al procedimiento almacenado
                Command.CommandText = "TBUSCACTIVIDAD";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", id);
                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = Command;
                DataSet ds = new DataSet();
                DataTable tabla;
                adap.Fill(ds);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();
                lstvActividades.Items.Clear();
                tabla = ds.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Llenarlist2(i, tabla, lstvActividades);
                }
                Command.Parameters.Clear();
                ConnectionBd.Close();
            }
        }

        /// <summary>
        /// Llena un elemento ListViewItem con los datos de una fila de la tabla y lo agrega a un ListView.
        /// </summary>
        /// <param name="i">Índice de la fila en la tabla.</param>
        /// <param name="tabla">Tabla que contiene los datos.</param>
        /// <param name="lstvActividades">ListView al que se agregará el elemento ListViewItem.</param>
        private void Llenarlist2(int i, DataTable tabla, ListView lstvActividades)
        {
            DataRow filas = tabla.Rows[i];
            ListViewItem elementos = new ListViewItem(filas["Id_Actividad"].ToString());
            elementos.SubItems.Add(filas["Nombre"].ToString());
            elementos.SubItems.Add(filas["Valor"].ToString());
            elementos.SubItems.Add(filas["Tipo"].ToString());
            elementos.SubItems.Add(filas["Representante"].ToString());
            lstvActividades.Items.Add(elementos);
        }

        /// <summary>
        /// Llena un ListView con los datos de actividades obtenidos de una consulta a la base de datos.
        /// </summary>
        /// <param name="lstvActividades">ListView en el que se mostrarán los datos de actividades.</param>
        internal void llenarlist2_1(ListView lstvActividades)
        {
            Command.Connection = ConnectionBd;
            Command.CommandText = "TBUSCACTIVIDAD2";
            Command.CommandType = CommandType.StoredProcedure;
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = Command;
            DataSet ds = new DataSet();
            DataTable tabla;
            adap.Fill(ds);
            ConnectionBd.Open();
            Command.ExecuteNonQuery();
            lstvActividades.Items.Clear();
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Llenarlist2(i, tabla, lstvActividades);
            }
            Command.Parameters.Clear();
            ConnectionBd.Close();
        }

        /// <summary>
        /// Llena el ComboBox con los nombres de las actividades.
        /// </summary>
        /// <param name="mycombo">ComboBox que se llenará con los nombres de las actividades.</param>
        internal void LlenarComboActividad(ComboBox mycombo)
        {
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                DataSet clientds = new DataSet();
                DataTable clientsTable;

                Command.Connection = ConnectionBd;
                Command.CommandText = "ACTIV";
                Command.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand = Command;
                dataAdapter.Fill(clientds);
                ConnectionBd.Open();
                Reader = Command.ExecuteReader();
                clientsTable = clientds.Tables[0];

                try
                {
                    for (int i = 0; i < clientsTable.Rows.Count; i++)
                    {
                        DataRow rowClient = clientsTable.Rows[i];
                        mycombo.Items.Add(rowClient["Nombre"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

                Command.Parameters.Clear();
                Reader.Close();
                ConnectionBd.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(@" " + ex);
            }
        }

        /// <summary>
        /// Obtiene los días y horas de una actividad seleccionada en el ComboBox.
        /// </summary>
        /// <param name="cmbtip">ComboBox que contiene la actividad seleccionada.</param>
        /// <param name="txtdias">TextBox en el que se mostrarán los días de la actividad.</param>
        /// <param name="txthora">TextBox en el que se mostrarán las horas de la actividad.</param>
        internal void LlenarHorario(ComboBox cmbtip, TextBox txtdias, TextBox txthora)
        {
            MySqlDataReader reader = null;
            try
            {
                ConnectionBd.Open();
                string busc = cmbtip.Text;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "LLENHORA";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", busc);
                reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Se llenan los Txt para poder modificarlos
                        txtdias.Text = reader.GetString(0);
                        txthora.Text = reader.GetString(1);
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
            finally
            {
                Command.Parameters.Clear();
                if (reader != null) reader.Close();
                ConnectionBd.Close();
            }
        }

        /// <summary>
        /// Registra una fuga de un recluso.
        /// </summary>
        /// <param name="txtced">TextBox con la cédula del recluso.</param>
        /// <param name="txtNom">TextBox con el nombre del recluso.</param>
        /// <param name="txtApe">TextBox con el apellido del recluso.</param>
        /// <param name="fecha">Fecha de la fuga.</param>
        /// <param name="txtMot">TextBox con el motivo de la fuga.</param>
        internal void Fuga(TextBox txtced, TextBox txtNom, TextBox txtApe, String fecha, TextBox txtMot)
        {
            string cedula = txtced.Text;
            string nombre = txtNom.Text;
            string apellido = txtApe.Text;
            string motivo = txtMot.Text;
            try
            {
                Command.Connection = ConnectionBd;
                Command.CommandText = "PROFUGA";
                Command.CommandType = CommandType.StoredProcedure;
                //Se manda los datos de la actividad que fueron ingresados a la base de datos para que puedan ser guardados
                Command.Parameters.AddWithValue("@ced", cedula);
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@ape", apellido);
                Command.Parameters.AddWithValue("@mot", motivo);
                Command.Parameters.AddWithValue("@dia", fecha);
                ConnectionBd.Open();
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

        /// <summary>
        /// Agrega un recluso a una actividad.
        /// </summary>
        /// <param name="txtNom">TextBox con el nombre del recluso.</param>
        /// <param name="txtApe">TextBox con el apellido del recluso.</param>
        /// <param name="txtced">TextBox con la cédula del recluso.</param>
        /// <param name="cmbtip">ComboBox con las actividades.</param>
        /// <param name="txtdias">TextBox con los días de la actividad.</param>
        /// <param name="txthora">TextBox con las horas de la actividad.</param>
        internal void AgreRecAct(TextBox txtNom, TextBox txtApe, TextBox txtced, ComboBox cmbtip, TextBox txtdias, TextBox txthora)
        {
            string nombre = txtNom.Text;
            string apellido = txtApe.Text;
            string cedula = txtced.Text;
            string tipo = cmbtip.Text;
            string dias = txtdias.Text;
            string hora = txthora.Text;

            try
            {
                ConnectionBd.Close();
                Command.Connection = ConnectionBd;
                Command.CommandText = "AGRERECACT";
                Command.CommandType = CommandType.StoredProcedure;
                //Se manda los datos de la actividad y del recluso  que fueron ingresados a la base de datos para que puedan ser guardados
                Command.Parameters.AddWithValue("@nom", nombre);
                Command.Parameters.AddWithValue("@ape", apellido);
                Command.Parameters.AddWithValue("@ced", cedula);
                Command.Parameters.AddWithValue("@tip", tipo);
                Command.Parameters.AddWithValue("@dia", dias);
                Command.Parameters.AddWithValue("@hor", hora);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();
                MessageBox.Show(@"Recluso agregado a la actividad...");
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
        /// Busca y muestra el número de cupos disponibles para una actividad.
        /// </summary>
        /// <param name="cmbtip">ComboBox con la actividad seleccionada.</param>
        internal void BuscCupos( ComboBox cmbtip)
        {
            int cup = 0;
            MySqlDataReader reader = null;
            try
            {
                ConnectionBd.Open();
                string busc = cmbtip.Text;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "TABACTIVIDAD";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", busc);
                reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cup = Int32.Parse(reader.GetString(7));
                    }
                }
                else
                {
                    throw new ExceptionRecluso();


                }

                ActCupo(cup, busc);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                if (reader != null) reader.Close();
                Command.Parameters.Clear();
            }
        }

        private void ActCupo(int cup, string busc)
        {
            cup = cup - 1;
            string Cup = cup.ToString();
            try
            {
                ConnectionBd.Close();
                ConnectionBd.Open();
                Command.Parameters.Clear();
                //Mandamamos los datos modificados a la base de datos para que se pueda actualizar con la condicion que le mandamos
                Command.Connection = ConnectionBd;
                Command.CommandText = "ACTCUPO";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@bus", busc);
                Command.Parameters.AddWithValue("@cup", Cup);
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

        /// <summary>
        /// Llena el ListView con los datos de los reclusos y sus actividades.
        /// </summary>
        /// <param name="listact">ListView en el que se mostrarán los datos.</param>
        internal void LLenarAct1(ListView listact)
        {
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "BUSCACTRECLU";
                Command.CommandType = CommandType.StoredProcedure;
                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = Command;
                DataSet ds = new DataSet();
                DataTable tabla;
                adap.Fill(ds);
                ConnectionBd.Open();
                Command.ExecuteNonQuery();
                listact.Items.Clear();
                tabla = ds.Tables[0];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    Llenartabla(i, tabla, listact);
                }
                Command.Parameters.Clear();
                ConnectionBd.Close();
        }

        /// <summary>
        /// Llena una tabla y un ListView con los datos de una fila de una DataTable.
        /// </summary>
        /// <param name="i">Índice de la fila a llenar en la DataTable.</param>
        /// <param name="tabla">DataTable que contiene los datos.</param>
        /// <param name="listact">ListView en el que se mostrarán los datos.</param>
        private void Llenartabla(int i, DataTable tabla, ListView listact)
        {
            // Obtiene la fila correspondiente al índice "i" en la DataTable
            DataRow filas = tabla.Rows[i];

            // Crea un nuevo ListViewItem y agrega los valores de la fila como subelementos
            ListViewItem elementos = new ListViewItem(filas["Nombre"].ToString());
            elementos.SubItems.Add(filas["Apellido"].ToString());
            elementos.SubItems.Add(filas["Cedula"].ToString());
            elementos.SubItems.Add(filas["Tipo"].ToString());

            // Agrega el ListViewItem al ListView
            listact.Items.Add(elementos);
        }

        /// <summary>
        /// Llena el ListView con los datos de los reclusos y sus actividades.
        /// </summary>
        /// <param name="listact">ListView en el que se mostrarán los datos.</param>
        /// <param name="tipo"></param>
        internal void LLenarAct2(ListView listact, string tipo)
        {
            //Si busca una actividad en especifico
            Command.Connection = ConnectionBd;
            //Llamamos al procedimiento almacenado
            Command.CommandText = "BUSCACTRECLU2";
            Command.CommandType = CommandType.StoredProcedure;
            Command.Parameters.AddWithValue("@busc", tipo);
            MySqlDataAdapter adap = new MySqlDataAdapter();
            adap.SelectCommand = Command;
            DataSet ds = new DataSet();
            DataTable tabla;
            adap.Fill(ds);
            ConnectionBd.Open();
            Command.ExecuteNonQuery();
            listact.Items.Clear();
            tabla = ds.Tables[0];
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                Llenartabla(i, tabla, listact);
            }
            Command.Parameters.Clear();
            ConnectionBd.Close();
        }
    }
}
