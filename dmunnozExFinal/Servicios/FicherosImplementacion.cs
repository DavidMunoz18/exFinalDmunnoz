using dmunnozExFinal.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmunnozExFinal.Servicios
{
    /// <summary>
    /// Clase que implementa los metodos relacionados con fichero
    /// </summary>
    internal class FicherosImplementacion : FicherosInterfaz
    {
        public void cargaInicial(string rutaCarga, List<CitasDto> listaCitas, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en la carga");
                }

                string[] leer = File.ReadAllLines(rutaCarga);

                foreach (string line in leer)
                {
                    string[] posiciones = line.Split(";");

                    CitasDto citas = new CitasDto();

                    citas.Dni = posiciones[0];

                    citas.Nombre = posiciones[1];

                    citas.Apellidos = posiciones[2];

                    citas.Especialidad = posiciones[3];

                    citas.FchaCita = Convert.ToDateTime(posiciones[4]);

                    citas.AsistenciaCita = Convert.ToBoolean(posiciones[5]);

                    listaCitas.Add(citas);
                }
            }catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Se ha producido un error en la carga de fichero, vuelva a intentarlo en 10 minutos");
                }
                
            }
        }

        public void escribirConsultasFisioterapia(List<CitasDto> listaCitas, string rutaFichero, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en escribir consultas fisioterapia");
                }


                Console.WriteLine("Introduzca la fecha que desee ver");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());

                using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                {



                    foreach (CitasDto cita in listaCitas)
                    {

                        if (cita.AsistenciaCita == true && cita.Especialidad.Equals("Fisioterapia") && cita.FchaCita.ToString("dd-MM-yyyy").Equals(fecha.ToString("dd-MM-yyyy")))
                        {

                            sw.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + "," + "hora: " + cita.FchaCita.Hour + ":" + cita.FchaCita.Minute);
                        }

                    }
                }
            }
            catch(Exception ex) {

                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Se ha producido un error en la carga de fichero, vuelva a intentarlo en 10 minutos");
                }
            }
        }

        public void escribirConsultasPsicologia(List<CitasDto> listaCitas, string rutaFichero, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en escribir consultas fisioterapia");
                }

                Console.WriteLine("Introduzca la fecha que desee ver");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());

                using (StreamWriter sw = new StreamWriter(rutaFichero, true))
                {

                    foreach (CitasDto cita in listaCitas)
                    {

                        if (cita.AsistenciaCita == true && cita.Especialidad.Equals("Psicología") && cita.FchaCita.ToString("dd-MM-yyyy").Equals(fecha.ToString("dd-MM-yyyy")))
                        {

                            sw.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + "," + "hora: " + cita.FchaCita.Hour + ":" + cita.FchaCita.Minute);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Se ha producido un error en la carga de fichero, vuelva a intentarlo en 10 minutos");
                }
            }
        }

        public void escribirConsultasTraumatologia(List<CitasDto> listaCitas, string rutaFichero, string rutaFicheroLog)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en escribir consultas fisioterapia");
                }
                Console.WriteLine("Introduzca la fecha que desee ver");
                DateTime fecha = Convert.ToDateTime(Console.ReadLine());

                using (StreamWriter sw = new StreamWriter(rutaFichero, true)) {

                    foreach (CitasDto cita in listaCitas)
                    {

                        if (cita.AsistenciaCita == true && cita.Especialidad.Equals("Traumatologia") && cita.FchaCita.ToString("dd-MM-yyyy").Equals(fecha.ToString("dd-MM-yyyy")))
                        {

                            sw.WriteLine("Nombre Completo: " + cita.Nombre + " " + cita.Apellidos + "," + "hora: " + cita.FchaCita.Hour + ":" + cita.FchaCita.Minute);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Se ha producido un error en la carga de fichero, vuelva a intentarlo en 10 minutos");
                }
            }
        }
    }
}
