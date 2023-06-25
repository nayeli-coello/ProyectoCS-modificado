using System;

namespace ProyectoCS.Excepciones
{
    public class ExceptionActividad : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ExceptionActividad con un mensaje de error predeterminado.
        /// </summary>
        public ExceptionActividad() : base("No existe tal actividad")
        {
        }
    }
}
