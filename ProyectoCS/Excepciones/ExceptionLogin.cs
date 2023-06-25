using System;

namespace ProyectoCS.Excepciones
{
    public class ExceptionLogin : Exception
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase ExceptionLogin con un mensaje de error predeterminado.
        /// </summary>
        public ExceptionLogin() : base("Usuario/Clave incorrectas....")
        {
        }
    }
}
