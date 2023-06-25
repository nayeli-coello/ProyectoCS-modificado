using MySql.Data.MySqlClient;
using ProyectoCS.Datos;
using ProyectoCS.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCS
{
    public partial class FrmLogin : Form
    {
        Login Log = new Login();
        public FrmLogin()
        {
            InitializeComponent();
        }
        //Evento del boton aceptar para ingresar al sistema
        private void Btnacep_Click(object sender, EventArgs e)  
        {
            //TryCatch que permite controlar las excepciones al ingresar incorrectamente un usuario/clave
            try
            {
                string usuario = Txtusu.Text;
                string clave = Txtcontr.Text;
                Boolean contrane = false;
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(clave))
                {
                    MessageBox.Show("Por favor llenar todos los campos....", "Sistema");

                }else
                {
                    //Mandamos a validar el usuario ingresado a ver si consta dentro de la base de datos
                    contrane = Log.IniciarSesion(usuario, clave);
                    if (contrane == true)
                    {
                        this.Hide();
                    }
                    else
                    {
                        throw new ExceptionLogin();
                    }
                }
            }catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ExceptionLogin)
            {
                Txtcontr.Clear();
                Txtusu.Clear();
            }
        }
        //Método que permite terminar la compilacion del programa
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
