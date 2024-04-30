using dmunnozExFinal.Dtos;
using dmunnozExFinal.Servicios;

namespace dmunnozExFinal.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// <author> dmp - 30/04/2024</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// Metodo de entrada y salida de la aplicación.
        /// <author> dmp - 30/04/2024</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            List<CitasDto> listaCitas = new List<CitasDto>();
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            FicherosInterfaz fi = new FicherosImplementacion();

            DateTime fechaHoy = DateTime.Today;


            string rutaFicheroLog = "log" + "-" + fechaHoy.ToString("dd-MM-yyyy").Replace("-", "") + ".txt";
            string rutaFichero = "citasConAsistencia" +"-" + fechaHoy.ToString("dd-MM-yyyy").Replace("-", "") + ".txt";
            string rutaCarga = "C:\\Users\\csi23-dmunnco\\source\\repos\\dmunnozExFinal\\bin\\Debug\\net6.0\\citas.txt";

            try
            {
                fi.cargaInicial(rutaCarga, listaCitas, rutaFicheroLog);

                using(StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                {
                    sw.WriteLine("Entra en la aplicación");
                }

                bool cerrarMenu = false;
                int opcion;
                while (!cerrarMenu)
                {
                    opcion = mi.mostrarMenuYSeleccionPrincipal();
                    switch (opcion)
                    {
                        case 0:
                            using (StreamWriter sw = new StreamWriter(rutaFicheroLog, true))
                            {
                                sw.WriteLine("Se cierra la aplicación");
                            }
                            cerrarMenu = true;
                            break;
                        case 1:
                            oi.registroLlegada(listaCitas, rutaFicheroLog);
                            break;
                        case 2:
                            int opcionAcciones = mi.mostrarAcciones();
                            switch (opcionAcciones)
                            {
                                case 0:
                                    break;
                                case 1:
                                    

                                    int opcionConsultas1 = mi.mostrarEspecialidades();
                                    switch (opcionConsultas1)
                                    {
                                        case 0:
                                            break;
                                        case 1:
                                            oi.mostrarConsultasPsicologia(listaCitas, rutaFicheroLog);
                                            break;
                                        case 2:
                                            oi.mostrarConsultasTraumatologia(listaCitas, rutaFicheroLog);
                                            break;
                                        case 3:
                                            oi.mostrarConsultasFisioterapia(listaCitas, rutaFicheroLog);
                                            break;
                                    }

                                    break;
                                case 2:
                                    int opcionConsultas2 = mi.mostrarEspecialidades();
                                    switch (opcionConsultas2)
                                    {
                                        case 0:
                                            break;
                                        case 1:
                                            fi.escribirConsultasPsicologia(listaCitas, rutaFichero, rutaFicheroLog);
                                            break;
                                        case 2:
                                            fi.escribirConsultasTraumatologia(listaCitas, rutaFichero, rutaFicheroLog);
                                            break;
                                        case 3:
                                            fi.escribirConsultasFisioterapia(listaCitas, rutaFichero, rutaFicheroLog);
                                            break;
                                    }
                                    break;

                            }

                            break;
                        default:
                            Console.WriteLine("No se ha encontrado ninguna opcion seleccionada");
                            break;

                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Ahora mismo se ha producido un error, intentelo de nuevo en 10 minutos");
            }
        }
    }
}
