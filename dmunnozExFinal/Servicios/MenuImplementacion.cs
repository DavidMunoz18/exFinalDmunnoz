using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos del menu interfaz
    /// <author> dmp - 30/04/2024</author>
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarAcciones()
        {
            int opcion;
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Mostrar consultas");
            Console.WriteLine("2. Imprimir consultas");
            opcion = Convert.ToInt32(Console.ReadLine());
            
            return opcion;
        }

        public int mostrarEspecialidades()
        {
            int opcion;
            Console.WriteLine("0. Volver");
            Console.WriteLine("1. Psicologia");
            Console.WriteLine("2. Traumatologia");
            Console.WriteLine("3. Fisioterapia");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        public int mostrarMenuYSeleccionPrincipal()
        {
            int opcion;
            Console.WriteLine("#########################");
            Console.WriteLine("0. Cerrar menu");
            Console.WriteLine("1. Registro de llegada");
            Console.WriteLine("2. Listado de consultas");
            Console.WriteLine("#########################");
            opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

    }
}
