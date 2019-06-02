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
            string rutaCarpetaDestino = @"D:\Carpeta-Morse";

            PrepararCarpeta(rutaCarpetaDestino);

            string ruta_archivo_morse = ConversorDeMorse.CrearArchivoMorse();
            ConversorDeMorse.LeerArchivoMorse(ruta_archivo_morse);

            ConversorDeMorse.CrearAudio(ruta_archivo_morse);
            
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

        
    }
}
