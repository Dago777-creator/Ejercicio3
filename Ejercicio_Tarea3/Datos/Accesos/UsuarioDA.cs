using Datos.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Accesos
{
    public class UsuarioDA
    {
        readonly string cadena = "Server=localhost;Port=3306;Database=Ejercicio_3;Uid=root;Pwd=dago.0806;";

        MySqlConnection conn;
        MySqlCommand cmd; 

        public Usuario Login(string codigo, string clave)
        {
            Usuario user = null;

            try
            {
                string sql = "SELECT * FROM usuario WHERE Codigo = @codigo, Clave = @clave;";


                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@clave", clave);

                MySqlDataReader reader = cmd.ExecuteReader(); 
                
                while(reader.Read())
                {
                    user = new Usuario();
                    user.Codigo = reader[0].ToString();
                    user.Nombre = reader[1].ToString();
                    user.Apelllido = reader[2].ToString();
                    user.Edad = Convert.ToInt32(reader[3]); 
                    user.Clave = reader[4].ToString();
                   
                }

                reader.Close();
                conn.Close(); 
            }
            catch (Exception ex)
            {

            }

            return user; 
        }

        public DataTable ListarUsuario()
        {
            DataTable ListarUsuarioDT = new DataTable();

            try
            {
                string sql = "SELECT * FROM usuario;";

                conn = new MySqlConnection(cadena);
                conn.Open();

                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                ListarUsuarioDT.Load(reader); 

            }
            catch ( Exception ex )
            {

            }
            return ListarUsuarioDT; 
        }

    }

}
