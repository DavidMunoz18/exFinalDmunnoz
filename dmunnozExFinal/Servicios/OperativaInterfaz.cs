using dmunnozExFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos que realizan la operativa de la apliacion
    /// <author> dmp - 30/04/2024</author>
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que registra la llegada de un paciente
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFicheroLog"></param>
        public void registroLlegada(List<CitasDto> listaCitas, string rutaFicheroLog);

        /// <summary>
        /// Metodo que muestra las consultas de psicologia
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFicheroLog"></param>
        public void mostrarConsultasPsicologia(List<CitasDto> listaCitas, string rutaFicheroLog);

        /// <summary>
        /// Metodo que muestra las consultas de fisioterapia
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFicheroLog"></param>
        public void mostrarConsultasFisioterapia(List<CitasDto> listaCitas, string rutaFicheroLog);

        /// <summary>
        /// Metodo que muestra las consultas de traumatologia
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="listaCitas"></param>
        /// <param name="rutaFicheroLog"></param>
        public void mostrarConsultasTraumatologia(List<CitasDto> listaCitas, string rutaFicheroLog);
    }
}
