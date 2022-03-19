using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Usuario
    {
        //propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apelllido { get; set; }
        public int Edad { get; set; }
        public string Clave { get; set; }

        //Constructor Vacio 
        public Usuario()
        {
        }
        //Constructor por parámetros
        public Usuario(string codigo, string nombre, string apelllido, int edad, string clave)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apelllido = apelllido;
            Edad = edad;
            Clave = clave;
        }
    }
}
