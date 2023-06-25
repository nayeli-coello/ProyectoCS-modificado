using System;

namespace ProyectoCS.Excepciones
{
    public class ExceptionRecluso : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ExceptionRecluso con un mensaje de error predeterminado.
        /// </summary>
        public ExceptionRecluso() : base("No se encontró tal recluso.")
        {
        }
    }
}