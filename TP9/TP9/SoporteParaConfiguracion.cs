using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class SoporteParaConfiguracion
    {
        static string archivoConfig = "config.dat";

        public static void CrearArchivoDeConfiguracion(string rutaCarpeta)
        {

            if (!Directory.Exists(rutaCarpeta))
            {
                try
                {
                    Directory.CreateDirectory(rutaCarpeta);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }

            if (!File.Exists(archivoConfig))
            {
                try
                {
                    File.Create(archivoConfig);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
            try
            {
                BinaryWriter binario = new BinaryWriter(File.OpenWrite(archivoConfig));
                binario.Write(rutaCarpeta);
                binario.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static string LeerConfiguracion()
        {
            BinaryReader binario = new BinaryReader(File.OpenRead(archivoConfig));

            return binario.ReadString();
        }
    }
}
