using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoCS.Datos
{
    public class Informes : DbContext
    {
        /// <summary>
        /// Genera un informe utilizando los datos de una tabla y lo muestra en un control ReportViewer.
        /// </summary>
        /// <param name="tabla">Tabla de datos que se utilizará para generar el informe.</param>
        /// <param name="reporte">Control ReportViewer donde se mostrará el informe.</param>
        /// <param name="datos">Nombre de los datos que se utilizarán en el informe.</param>
        internal void Reporte(DataTable tabla, ReportViewer reporte, string datos)
        {
            reporte.LocalReport.DataSources.Clear();
            ReportDataSource report = new ReportDataSource(datos, tabla);
            reporte.LocalReport.DataSources.Add(report);
            reporte.RefreshReport();
        }

        /// <summary>
        /// Genera un informe de representantes y lo muestra en un control ReportViewer.
        /// </summary>
        /// <param name="reportRepres">Control ReportViewer donde se mostrará el informe de representantes.</param>
        public void ReportRepresentante(ReportViewer reportRepres)
        {
            string Reportes = "Representante";
            DataTable tabla = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter();
            Command.Connection = ConnectionBd;
            //Llamamos al procedimiento almacenado
            Command.CommandText = "REPORREPRESENTANTE";
            Command.CommandType = CommandType.StoredProcedure;
            ConnectionBd.Open();
            Command.ExecuteNonQuery();
            adap.SelectCommand = Command;
            adap.Fill(tabla);
            Reporte(tabla, reportRepres, Reportes);
            Command.Parameters.Clear();
            ConnectionBd.Close();
        }

        /// <summary>
        /// Genera un informe de reclusos y lo muestra en un control ReportViewer.
        /// </summary>
        /// <param name="reportRecluso">Control ReportViewer donde se mostrará el informe de reclusos.</param>
        public void ReportRecluso(ReportViewer reportRecluso)
        {
            string Reportes = "Reclusos";
            DataTable tabla = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter();
            Command.Connection = ConnectionBd;
            //Llamamos al procedimiento almacenado
            Command.CommandText = "REPORRECLUSO";
            Command.CommandType = CommandType.StoredProcedure;
            ConnectionBd.Open();
            Command.ExecuteNonQuery();
            adap.SelectCommand = Command;
            adap.Fill(tabla);
            Reporte(tabla, reportRecluso, Reportes);
            Command.Parameters.Clear();
            ConnectionBd.Close();
        }

        /// <summary>
        /// Genera un informe de actividades y lo muestra en un control ReportViewer.
        /// </summary>
        /// <param name="reportActiv">Control ReportViewer donde se mostrará el informe de actividades.</param>
        public void ReportActividades(ReportViewer reportActiv)
        {
            string Reportes = "Actividades";
            DataTable tabla = new DataTable();
            MySqlDataAdapter adap = new MySqlDataAdapter();
            Command.Connection = ConnectionBd;
            //Llamamos al procedimiento almacenado
            Command.CommandText = "REPORACTIVIDADES";
            Command.CommandType = CommandType.StoredProcedure;
            ConnectionBd.Open();
            Command.ExecuteNonQuery();
            adap.SelectCommand = Command;
            adap.Fill(tabla);
            Reporte(tabla, reportActiv, Reportes);
            Command.Parameters.Clear();
            ConnectionBd.Close();
        }
    }
}
