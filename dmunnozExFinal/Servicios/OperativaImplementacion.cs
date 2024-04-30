using dmunnozExFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos de la interfaz
    /// <author> dmp - 30/04/2024</author>
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void registroLlegada(List<CitasDto> listaCitas, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en el registro");
                }

                char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

                Console.WriteLine("Introduce su dni (numero)");
                int numeroUsu = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Introduce su dni (letra)");
                char letraUsu = Convert.ToChar(Console.ReadLine());

                string dniJunto = numeroUsu.ToString() + letraUsu.ToString();

                int resto = numeroUsu % 23;

                Console.WriteLine(dniJunto);

                DateTime fechaHoy = DateTime.Today;



                foreach (CitasDto cita in listaCitas)
                {


                    if (letras[resto] == letraUsu && dniJunto.Equals(cita.Dni) && fechaHoy.ToString("dd/MM/yyyy").Equals(cita.FchaCita.ToString("dd/MM/yyyy")))
                    {

                        cita.AsistenciaCita = true;
                        Console.WriteLine("Espere su turno para la consulta de Psicología en la sala de espera. Su especialista le avisará");
                    }else{
                    Console.WriteLine("No dispone de cita previa para hoy");
                    }

                }

            }catch(Exception ex) {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Ha ocurrido un error" + ex.Message);
                }
            }
            

           
        }
        public void mostrarConsultasFisioterapia(List<CitasDto> listaCitas, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en mostrar consultas fisioterapia");
                }


                Console.WriteLine("Introduzca la fecha que desee ver");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());



                foreach (CitasDto cita in listaCitas)
                {


                    if (cita.Especialidad.Equals("Fisioterapia") && cita.FchaCita.ToString("dd-MM-yyyy").Equals(fecha.ToString("dd-MM-yyyy")))
                    {

                        Console.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + "," + "hora: " + cita.FchaCita.Hour + ":" + cita.FchaCita.Minute);
                    }

                }
            }catch(Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Ha ocurrido un error" + ex.Message);
                }
            }
        }

        public void mostrarConsultasPsicologia(List<CitasDto> listaCitas, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Ha entrado en mostrar consultas psicologia");
                }


                Console.WriteLine("Introduzca la fecha que desee ver");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());



                foreach (CitasDto cita in listaCitas)
                {

                    if (cita.Especialidad.Equals("Psicología") && cita.FchaCita.ToString("dd-MM-yyyy").Equals(fecha.ToString("dd-MM-yyyy")))
                    {

                        Console.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + "," + "hora: " + cita.FchaCita.Hour + ":" + cita.FchaCita.Minute);
                    }

                }
            }catch(Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Ha ocurrido un error" + ex.Message);
                }
            }
        }

        public void mostrarConsultasTraumatologia(List<CitasDto> listaCitas, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Ha entrado en mostrar consultas traumatología" );
                }


                Console.WriteLine("Introduzca la fecha que desee ver");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());

                foreach (CitasDto cita in listaCitas)
                {

                    if (cita.Especialidad.Equals("Traumatología") && cita.FchaCita.ToString("dd-MM-yyyy").Equals(fecha.ToString("dd-MM-yyyy")))
                    {

                        Console.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + "," + "hora: " + cita.FchaCita.Hour + ":" + cita.FchaCita.Minute);
                    }

                }
            }catch(Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Ha ocurrido un error" + ex.Message);
                }
            }
        }
    }
}
