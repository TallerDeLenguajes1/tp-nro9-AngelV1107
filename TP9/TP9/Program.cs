using Helpers;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaCarpetaDestino = @"C:\Carpeta-Morse";

            PrepararCarpeta(rutaCarpetaDestino);

            //string cadena = "The quick brown fox jumped over the lazy dog 0123456789";
            //string cadena_morse = ConversorDeMorse.TextoAMorse(cadena);

            //Console.WriteLine(cadena.ToUpper());
            //Console.WriteLine(ConversorDeMorse.MorseATexto(cadena_morse));

            CrearArchivoMorse();

            Console.ReadKey();
        }

        public static void PrepararCarpeta(string rutaCarpetaDestino)
        {
            try
            {
                SoporteParaConfiguracion.CrearArchivoDeConfiguracion(rutaCarpetaDestino);

                rutaCarpetaDestino = SoporteParaConfiguracion.LeerConfiguracion();

                foreach (string rutaArchivo in Directory.GetFiles(Directory.GetCurrentDirectory()))
                {
                    if ((Path.GetExtension(rutaArchivo) == ".mp3") || (Path.GetExtension(rutaArchivo) == ".txt"))
                    {
                        if (!File.Exists(rutaCarpetaDestino + @"\" + Path.GetFileName(rutaArchivo)))
                        {
                            string rutaArchivoDestino = rutaCarpetaDestino + @"\" + Path.GetFileName(rutaArchivo);

                            Console.WriteLine("Copiando {0} a {1}", Path.GetFileName(rutaArchivo), rutaArchivoDestino);

                            File.Copy(rutaArchivo, rutaArchivoDestino);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex);
                throw;
            }
        }

        public static void CrearArchivoMorse()
        {
            Console.WriteLine("Escriba el texto que desea convertir a morse");
            string texto = Console.ReadLine();

            string cadena_morse = ConversorDeMorse.TextoAMorse(texto);

            string rutaArchivo;
            string nombreArchivo;

            nombreArchivo = "morse_" + DateTime.Now.ToString() + ".txt";
            nombreArchivo = nombreArchivo.Replace('/', '-');
            nombreArchivo = nombreArchivo.Replace(' ', '_');
            nombreArchivo = nombreArchivo.Replace(':', '-');

            rutaArchivo = SoporteParaConfiguracion.LeerConfiguracion() + @"\" + nombreArchivo;

            Console.WriteLine(rutaArchivo);
        }
    }
}
