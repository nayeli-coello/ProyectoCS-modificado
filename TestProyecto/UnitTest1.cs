using ProyectoCS.Metodos;
using System.Diagnostics.Contracts;

namespace TestProyecto
{
    public class Tests
    {
        ConnectBDD Bd = new ConnectBDD();
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void pruebaLogin()
        {
            string usuario = "Cesar";
            string clave = "123";
            Boolean contrane = false;
            Bd.login(usuario, clave);
            Assert.AreEqual(contrane == true);
        }
    }
}