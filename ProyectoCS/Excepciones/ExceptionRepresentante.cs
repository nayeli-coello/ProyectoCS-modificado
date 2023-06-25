using System;

namespace ProyectoCS.Excepciones
{
    /// <summary>
    /// Excepción lanzada cuando no se encuentra un representante.
    /// </summary>
    public class ExceptionRepresentante : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ExceptionRepresentante con un mensaje de error predeterminado.
        /// </summary>
        public ExceptionRepresentante() : base("No se encontró tal representante.")
        {
        }
    }
}

