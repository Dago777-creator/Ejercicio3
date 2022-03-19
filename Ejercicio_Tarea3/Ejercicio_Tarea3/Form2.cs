using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos.Accesos; 

namespace Ejercicio_Tarea3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        UsuarioDA usuarioDA = new UsuarioDA();

        private void Form2_Load(object sender, EventArgs e)
        {
            UsuariosdataGridView1.DataSource = usuarioDA.ListarUsuario(); 
        }


    }
}
