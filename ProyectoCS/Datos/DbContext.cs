using MySql.Data.MySqlClient;

namespace ProyectoCS.Datos
{
    /// <summary>
    /// Clase que proporciona una conexión a la base de datos.
    /// </summary>
    public class DbContext
    {
        /// <summary>
        /// Conexion con mi base de datos.
        /// </summary>
        protected MySqlConnection ConnectionBd = new MySqlConnection("server= btxxzyr0ildyylyibkf2-mysql.services.clever-cloud.com; " +
        "port= 3306; user id=uiw3felwq3nefzn6; password=byRQJsOZPoqRUBP6Gomr; database=btxxzyr0ildyylyibkf2;");

        //Reader
        /// <summary>
        /// Reader: Lector de resultados de la base de datos.
        /// </summary>
        protected MySqlDataReader Reader;
        /// <summary>
        /// Lector de resultados
        /// </summary>
        protected MySqlDataReader reader = null;


        /// <summary>
        /// Comando utilizado para ejecutar consultas en la base de datos.
        /// </summary>
        protected MySqlCommand Command = new MySqlCommand();
        
    }
}
