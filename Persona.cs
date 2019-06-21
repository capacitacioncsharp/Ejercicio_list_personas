using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_list_personas
{
    public class Persona
    {
        //Propiedades auto implementadas
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public decimal peso { get; set; }
        //Constructor
        public Persona()
        {
            Id = 0;
            Nombre = string.Empty;
            Apellidos = "";
            Edad = 0;
        }

        public Persona(int id,string nombre,string apellidos,int edad)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
        }
    }
}
