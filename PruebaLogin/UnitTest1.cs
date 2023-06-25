using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using ProyectoCS.Control;
using ProyectoCS.Datos;
using System.Data;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;


namespace PruebaLogin
{
    [TestClass]
    public class UnitTest1 : DbContext
    {

        //CP-001
        [TestMethod]
        public void TestSesion()
        {
            //Arrange
            string usu = "Cesar";
            string cla = "123";
            bool result = false;
            
            //Act
            try {
                ConnectionBd.Close();
                ConnectionBd.Open();
                MySqlDataReader reader = null;
                Command.Connection = ConnectionBd;
                Command.CommandText = "INICIAR";
                Command.CommandType = CommandType.StoredProcedure;
                //Mandamos esta linea a la aplicacion de MySQL para traer los datos que estamos requiriendo 
                Command.Parameters.AddWithValue("@usu", usu);
                Command.Parameters.AddWithValue("@cla", cla);
                Command.ExecuteNonQuery();
                //Verifica si con la coincidencia se encontro 
                reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    if (Convert.ToString(reader["Nombre_de_usu"]) == usu && Convert.ToString(reader["Clave"]) == cla)
                    {
                        result = true;
                    }
                }
            }
            catch (MySqlException)
            {
                result = false;
            }
          
            //Assert
            Assert.AreEqual(result, true);           
        }

        //CP-002
        [TestMethod]
        public void TestBuscarRecluso()
        {
            //Arrange
            bool result = true;
            string busc = "1234";

            //Act
            try
            {
                ConnectionBd.Open();
                
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Connection = ConnectionBd;
                Command.CommandText = "BUSCRECLUSO";
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("@busc", busc);
                reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //Se llenan los Txt para poder modificarlos
                    }
                }
                else
                {
                    result = false;
                }

            }
            catch (MySqlException )
            {
                result = true;
            }

            //Assert
            Assert.AreEqual(result, false);
        }

        //CP-003
        [TestMethod]
        public void TestBuscarRepresentante()
        {
            //Arrange
            bool result = false;
            string busc = "1804706693";

            //Act
            try
            {
                ConnectionBd.Open();
                Command.Connection = ConnectionBd;
                Command.CommandText = "BUSCREPRESENTANTE";
                Command.CommandType = CommandType.StoredProcedure;
                //Buscamos los datos del recluso con la condicion de la cedula
                Command.Parameters.AddWithValue("@busc", busc);
                reader = Command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = true;
                    }
                }
                else
                {
                    //Mensaje que no se encontro el representante
                }

            }
            catch (MySqlException)
            {
                result = false;
            }

            //Assert
            Assert.AreEqual(result, true);
        }

        //CP-004
        [TestMethod]
        public void TestBuscarActividad()
        {
            //Arrange
            bool result = false;
            string busc = "Act-001";

            //Act
            try
            {
                ConnectionBd.Open();
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
                        result = true;
                    }
                }
                else
                {
                    //Mensaje que no se encontro la actividad
                }

            }
            catch (MySqlException)
            {
                result = false;
            }

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}