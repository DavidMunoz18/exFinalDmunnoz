using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Dtos
{
    /// <summary>
    /// Clase que contiene toda la creacion de la cita
    /// <author>dmp - 30/04/24 </author>
    /// </summary>
    internal class CitasDto
    {
        long id;
        string dni = "aaaaa";
        string nombre = "aaaaa";
        string apellidos = "aaaaa";
        string especialidad = "aaaaa";
        DateTime fchaCita = DateTime.Today;
        bool asistenciaCita = false;

        public long Id { get => id; set => id = value; }
        public string Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public DateTime FchaCita { get => fchaCita; set => fchaCita = value; }
        public bool AsistenciaCita { get => asistenciaCita; set => asistenciaCita = value; }

        public CitasDto()
        {
        }

        public CitasDto(string dni, string nombre, string apellidos, string especialidad, DateTime fchaCita, bool asistenciaCita)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.especialidad = especialidad;
            this.fchaCita = fchaCita;
            this.asistenciaCita = asistenciaCita;
        }
    }
}
