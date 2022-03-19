using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Datos.Accesos;
using Datos.Entidades; 


namespace Ejercicio_Tarea3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
           UsuarioDA usuarioDA = new UsuarioDA();
           Usuario usuario = new Usuario();

            usuario = usuarioDA.Login(UsuariotextBox.Text, ClavetextBox.Text); 

            if(usuario == null)
            {
                MessageBox.Show("Usuario No Conocido");
                return; 
            }

                MessageBox.Show("Usuario Conectado Correctamente");

            Form2 formularioUsuario = new Form2();
            formularioUsuario.Show(); 
        }
    }
}
