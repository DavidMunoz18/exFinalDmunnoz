using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con el menu.
    /// <author> dmp - 30/04/2024</author>
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal y permite seleccionarlo
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccionPrincipal();

        /// <summary>
        /// Metodo que muestra las especialidades
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarEspecialidades();

        /// <summary>
        /// Metodo que muestra las acciones
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <returns></returns>
        public int mostrarAcciones();
    }
}
