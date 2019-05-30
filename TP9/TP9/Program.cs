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
            string rutaCarpetaDestino;

            SoporteParaConfiguracion.CrearArchivoDeConfiguracion(@"C:\Taller1-TP9-CarpetaMorse");

            rutaCarpetaDestino = SoporteParaConfiguracion.LeerConfiguracion();

            //Console.WriteLine(rutaCarpetaDestino);

            foreach (string rutaArchivo in Directory.GetFiles(Directory.GetCurrentDirectory()))
            {
                //Console.WriteLine(archivo);
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

            
            

            Console.ReadKey();
        }
    }
}
