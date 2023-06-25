using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ProyectoCS.Datos
{
    /// <summary>
    /// Clase que representa un objeto de Usuario.
    /// Proporciona métodos para buscar usuarios y mostrar los resultados en una ListView.
    /// </summary>
    public class Usuario : DbContext {
        /// <summary>
        /// Busca los usuarios en base a los criterios de usuario y cédula, y muestra los resultados en una ListView.
        /// </summary>
        /// <param name="usuario">El tipo de usuario a buscar ("Recluso" o "Representante").</param>
        /// <param name="cedula">La cédula del usuario a buscar.</param>
        /// <param name="listper">La ListView en la que se mostrarán los resultados.</param>
        internal void BuscarUsuario(string usuario, string cedula, ListView listper) {
            //Buscamos la coincidencia que el usuario sea Recluso
            if (usuario == "Recluso") {
                //Muestra todos los reclusos
                if (cedula == "") {
                    Command.Connection = ConnectionBd;
                    Command.CommandText = "USURECLUSO";
                    Command.CommandType = CommandType.StoredProcedure;
                    var adapt = new MySqlDataAdapter {
                        SelectCommand = Command
                    };
                    var ds = new DataSet();
                    adapt.Fill(ds);
                    ConnectionBd.Open();
                    Reader = Command.ExecuteReader();
                    var tabla = ds.Tables[0];
                    listper.Items.Clear();
                    for (var i = 0; i < tabla.Rows.Count; i++) {
                        LlenarList(i, tabla, listper);
                    }
                    Command.Parameters.Clear();
                    Reader.Close();
                    ConnectionBd.Close();
                }else {
                    //Muestra al recluso buscado por cedula
                    Command.Connection = ConnectionBd;
                    Command.CommandText = "USUCEDRECLUSO";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@ced", cedula);
                    var adapt = new MySqlDataAdapter {
                        SelectCommand = Command
                    };
                    var ds = new DataSet();
                    adapt.Fill(ds);
                    ConnectionBd.Open();
                    Reader = Command.ExecuteReader();
                    var tabla = ds.Tables[0];
                    listper.Items.Clear();
                    for (var i = 0; i < tabla.Rows.Count; i++) {
                        LlenarList(i, tabla, listper);
                    }
                    Command.Parameters.Clear();
                    Reader.Close();
                    ConnectionBd.Close();
                }
            } else if (usuario == "Representante") {//Buscamos la coincidencia que el usuario sea representante
                //Muestra todos los representantes
                if (cedula == "") {
                    Command.Connection = ConnectionBd;
                    Command.CommandText = "USUREPRESENTANTE";
                    Command.CommandType = CommandType.StoredProcedure;
                    var adapt = new MySqlDataAdapter {
                        SelectCommand = Command
                    };
                    var ds = new DataSet();
                    adapt.Fill(ds);
                    ConnectionBd.Open();
                    Reader = Command.ExecuteReader();
                    var tabla = ds.Tables[0];
                    listper.Items.Clear();
                    for (int i = 0; i < tabla.Rows.Count; i++) {
                        LlenarList(i, tabla, listper);
                    }
                    Command.Parameters.Clear();
                    Reader.Close();
                    ConnectionBd.Close();
                }else {
                    //Muestra al representante buscado por cedula
                    Command.Connection = ConnectionBd;
                    Command.CommandText = "USUCEDREPRESENTANTE";
                    Command.CommandType = CommandType.StoredProcedure;
                    Command.Parameters.AddWithValue("@ced", cedula);
                    var adapt = new MySqlDataAdapter {
                        SelectCommand = Command
                    };
                    var ds = new DataSet();
                    adapt.Fill(ds);
                    ConnectionBd.Open();
                    Reader = Command.ExecuteReader();
                    var tabla = ds.Tables[0];
                    listper.Items.Clear();
                    for (var i = 0; i < tabla.Rows.Count; i++) {
                        LlenarList(i, tabla, listper);
                    }
                    Command.Parameters.Clear(); 
                    Reader.Close(); 
                    ConnectionBd.Close(); 
                }
            }
        }

        /// <summary>
        /// Llena los elementos de una ListView con los datos de una fila de la tabla.
        /// </summary>
        /// <param name="i">El índice de la fila.</param>
        /// <param name="tabla">La tabla que contiene los datos.</param>
        /// <param name="listper">La ListView en la que se mostrarán los resultados.</param>
        private void LlenarList(int i, DataTable tabla, ListView listper) {
            var filas = tabla.Rows[i];
            var elementos = new ListViewItem(filas["Nombre"].ToString());
            elementos.SubItems.Add(filas["Apellido"].ToString());
            elementos.SubItems.Add(filas["Cedula"].ToString());
            elementos.SubItems.Add(filas["Fecha_Nacimiento"].ToString());
            listper.Items.Add(elementos);
        }
    }
}
