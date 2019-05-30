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
                Directory.CreateDirectory(rutaCarpeta);
            }

            if (!File.Exists(archivoConfig))
            {
                File.Create(archivoConfig);
            }

            BinaryWriter binario = new BinaryWriter(File.Open(archivoConfig, FileMode.Open));

            binario.Write(rutaCarpeta);
            binario.Close();
        }

        public static string LeerConfiguracion()
        {
            BinaryReader binario = new BinaryReader(File.OpenRead(archivoConfig));

            return binario.ReadString();
        }
    }
}
