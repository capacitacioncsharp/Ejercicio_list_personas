using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//agregamos la librería
using System.Collections;

namespace ejercicio_list_personas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de la lista
            List<Persona> personas = new List<Persona>();
            //Variables a utilizar
            int id = 0;
            string nombre = "";
            string apellidos = "";
            int edad = 0;
            int opcion = 0;
            int cantidad = 0;
            string leer = "";
            //Menú
            do
            {
                Console.WriteLine("Menú");
                Console.WriteLine("1.- Agregar");
                Console.WriteLine("2.- Agregar por bloque");
                Console.WriteLine("3.- Eliminar");
                Console.WriteLine("4.- Limpiar la lista");
                Console.WriteLine("5.- Imprimir");
                Console.WriteLine("6.- Salir");
                Console.WriteLine("Elije una opción");
                leer = Console.ReadLine();
                opcion = Convert.ToInt32(leer);

                //Opciones
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el id");
                        leer = Console.ReadLine();
                        id = Convert.ToInt32(leer);
                        Console.WriteLine("Ingrese el nombre");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese los apellidos");
                        apellidos = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad");
                        leer = Console.ReadLine();
                        edad = Convert.ToInt32(leer);
                        personas.Add(new Persona() {
                            Id = id,
                            Nombre = nombre,
                            Apellidos = apellidos,
                            Edad = edad
                        });
                        /*
                        Persona persona = new Persona(id, nombre, apellidos, edad);
                        personas.Add(persona);*/
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la cantidad de personas a agregar");
                        leer = Console.ReadLine();
                        cantidad = Convert.ToInt32(leer);
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Persona {0}", i+1);
                            Console.WriteLine("Ingrese el id");
                            leer = Console.ReadLine();
                            id = Convert.ToInt32(leer);
                            Console.WriteLine("Ingrese el nombre");
                            nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese los apellidos");
                            apellidos = Console.ReadLine();
                            Console.WriteLine("Ingrese la edad");
                            leer = Console.ReadLine();
                            edad = Convert.ToInt32(leer);
                            Persona persona = new Persona(id, nombre, apellidos, edad);
                            personas.Add(persona);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el id de la persona qeu desea eliminar");
                        leer = Console.ReadLine();
                        id = Convert.ToInt32(leer);
                        eliminar(id,personas);
                        break;
                    case 4:
                        personas.Clear();
                        break;
                    case 5:
                        imprimir(personas);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("La opción no esta en el menú");
                        break;
                }
            } while (opcion != 6 );
            Console.ReadKey();
        }

        public static void imprimir(List<Persona> lista)
        {
            Console.WriteLine("Personas: ");
            foreach (var p in lista)
            {
                Console.WriteLine("Id: " + p.Id);
                Console.WriteLine("Nombre: " + p.Nombre);
                Console.WriteLine("Apellidos : " + p.Apellidos);
                Console.WriteLine("Edad: "  + p.Edad);
                Console.WriteLine("-------------------------");
            }
           
        }
        //Método para eliminar por el id
        public static void eliminar(int id, List<Persona> lista)
        {
            //Buscamos el elemento
            var ele = lista.FirstOrDefault(p => p.Id == id);
            if (ele != null)
            {
                lista.Remove(ele);
                Console.WriteLine("El elemento ha sido eliminado");
            }
            else
            {
                Console.WriteLine("El elemento no existe");
            }
        }
    }
}
