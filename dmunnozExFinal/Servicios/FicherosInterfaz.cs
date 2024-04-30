using dmunnozExFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos relacionados con ficheros
    /// <author> dmp - 30/04/2024</author>
    /// </summary>
    internal interface FicherosInterfaz
    {
        /// <summary>
        /// Metodo que contiene la carga inicial de la aplicación
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="rutaCarga"></param>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFicheroLog"></param>
        public void cargaInicial(string rutaCarga, List<CitasDto> listaCitas, string rutaFicheroLog);

        /// <summary>
        /// Metodo que escribe las consultas de psicologia en un fichero
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFichero"></param>
        /// <param name="rutaFicheroLog"></param>
        public void escribirConsultasPsicologia(List<CitasDto> listaCitas, string rutaFichero, string rutaFicheroLog);

        /// <summary>
        /// Metodo que escribe las consultas de fisioterapia en un fichero
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFichero"></param>
        /// <param name="rutaFicheroLog"></param>
        public void escribirConsultasFisioterapia(List<CitasDto> listaCitas, string rutaFichero, string rutaFicheroLog);

        /// <summary>
        /// Metodo que escribe las consultas de traumatologia en un fichero
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFichero"></param>
        /// <param name="rutaFicheroLog"></param>
        public void escribirConsultasTraumatologia(List<CitasDto> listaCitas, string rutaFichero, string rutaFicheroLog);

    }
}
