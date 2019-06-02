using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class ConversorDeMorse
    {
        public static string TextoAMorse(string texto_original)
        {
            StringBuilder texto_morse = new StringBuilder();

            foreach (char letra in texto_original.ToLower())
            {
                switch (letra)
                {
                    case 'a':
                        texto_morse.Append(".-");
                        break;
                    case 'b':
                        texto_morse.Append("-...");
                        break;
                    case 'c':
                        texto_morse.Append("-.-.");
                        break;
                    case 'd':
                        texto_morse.Append("-..");
                        break;
                    case 'e':
                        texto_morse.Append(".");
                        break;
                    case 'f':
                        texto_morse.Append("..-.");
                        break;
                    case 'g':
                        texto_morse.Append("--.");
                        break;
                    case 'h':
                        texto_morse.Append("....");
                        break;
                    case 'i':
                        texto_morse.Append("..");
                        break;
                    case 'j':
                        texto_morse.Append(".---");
                        break;
                    case 'k':
                        texto_morse.Append("-.-");
                        break;
                    case 'l':
                        texto_morse.Append(".-..");
                        break;
                    case 'm':
                        texto_morse.Append("--");
                        break;
                    case 'n':
                        texto_morse.Append("-.");
                        break;
                    case 'o':
                        texto_morse.Append("---");
                        break;
                    case 'p':
                        texto_morse.Append(".--.");
                        break;
                    case 'q':
                        texto_morse.Append("--.-");
                        break;
                    case 'r':
                        texto_morse.Append(".-.");
                        break;
                    case 's':
                        texto_morse.Append("...");
                        break;
                    case 't':
                        texto_morse.Append("-");
                        break;
                    case 'u':
                        texto_morse.Append("..-");
                        break;
                    case 'v':
                        texto_morse.Append("...-");
                        break;
                    case 'w':
                        texto_morse.Append(".--");
                        break;
                    case 'x':
                        texto_morse.Append("-..-");
                        break;
                    case 'y':
                        texto_morse.Append("-.--");
                        break;
                    case 'z':
                        texto_morse.Append("--..");
                        break;
                    case '0':
                        texto_morse.Append("-----");
                        break;
                    case '1':
                        texto_morse.Append(".----");
                        break;
                    case '2':
                        texto_morse.Append("..---");
                        break;
                    case '3':
                        texto_morse.Append("...--");
                        break;
                    case '4':
                        texto_morse.Append("....-");
                        break;
                    case '5':
                        texto_morse.Append(".....");
                        break;
                    case '6':
                        texto_morse.Append("-....");
                        break;
                    case '7':
                        texto_morse.Append("--...");
                        break;
                    case '8':
                        texto_morse.Append("---..");
                        break;
                    case '9':
                        texto_morse.Append("----.");
                        break;
                    case ' ':
                        texto_morse.Append("/");
                        break;
                }

                texto_morse.Append(' ');
            }

            return texto_morse.ToString();
        }

        public static string MorseATexto(string texto_morse)
        {
            StringBuilder texto_decodificado = new StringBuilder();

            foreach (string letra_morse in texto_morse.Split(' '))
            {
                switch (letra_morse)
                {
                    case ".-":
                        texto_decodificado.Append('A');
                        break;
                    case "-...":
                        texto_decodificado.Append('B');
                        break;
                    case "-.-.":
                        texto_decodificado.Append('C');
                        break;
                    case "-..":
                        texto_decodificado.Append('D');
                        break;
                    case ".":
                        texto_decodificado.Append('E');
                        break;
                    case "..-.":
                        texto_decodificado.Append('F');
                        break;
                    case "--.":
                        texto_decodificado.Append('G');
                        break;
                    case "....":
                        texto_decodificado.Append('H');
                        break;
                    case "..":
                        texto_decodificado.Append('I');
                        break;
                    case ".---":
                        texto_decodificado.Append('J');
                        break;
                    case "-.-":
                        texto_decodificado.Append('K');
                        break;
                    case ".-..":
                        texto_decodificado.Append('L');
                        break;
                    case "--":
                        texto_decodificado.Append('M');
                        break;
                    case "-.":
                        texto_decodificado.Append('N');
                        break;
                    case "---":
                        texto_decodificado.Append('O');
                        break;
                    case ".--.":
                        texto_decodificado.Append('P');
                        break;
                    case "--.-":
                        texto_decodificado.Append('Q');
                        break;
                    case ".-.":
                        texto_decodificado.Append('R');
                        break;
                    case "...":
                        texto_decodificado.Append('S');
                        break;
                    case "-":
                        texto_decodificado.Append('T');
                        break;
                    case "..-":
                        texto_decodificado.Append('U');
                        break;
                    case "...-":
                        texto_decodificado.Append('V');
                        break;
                    case ".--":
                        texto_decodificado.Append('W');
                        break;
                    case "-..-":
                        texto_decodificado.Append('X');
                        break;
                    case "-.--":
                        texto_decodificado.Append('Y');
                        break;
                    case "--..":
                        texto_decodificado.Append('Z');
                        break;
                    case "-----":
                        texto_decodificado.Append('0');
                        break;
                    case ".----":
                        texto_decodificado.Append('1');
                        break;
                    case "..---":
                        texto_decodificado.Append('2');
                        break;
                    case "...--":
                        texto_decodificado.Append('3');
                        break;
                    case "....-":
                        texto_decodificado.Append('4');
                        break;
                    case ".....":
                        texto_decodificado.Append('5');
                        break;
                    case "-....":
                        texto_decodificado.Append('6');
                        break;
                    case "--...":
                        texto_decodificado.Append('7');
                        break;
                    case "---..":
                        texto_decodificado.Append('8');
                        break;
                    case "----.":
                        texto_decodificado.Append('9');
                        break;
                    case "/":
                        texto_decodificado.Append(' ');
                        break;
                    default:
                        break;
                }
            }

            return texto_decodificado.ToString();
        }

        public static string CrearArchivoMorse()
        {
            Console.WriteLine("Escriba el texto que desea convertir a morse");
            string texto = Console.ReadLine();

            string cadena_morse = ConversorDeMorse.TextoAMorse(texto);

            //Crear directorio Morse, a menos que ya exista
            try
            {
                Directory.CreateDirectory(SoporteParaConfiguracion.LeerConfiguracion() + @"\Morse");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: {0}", ex);
                throw;
            }

            //Preparar string de ruta de archivo
            string rutaArchivo;
            string nombreArchivo;

            nombreArchivo = "morse_" + DateTime.Now.ToString() + ".txt";
            nombreArchivo = nombreArchivo.Replace('/', '-');
            nombreArchivo = nombreArchivo.Replace(' ', '_');
            nombreArchivo = nombreArchivo.Replace(':', '-');

            rutaArchivo = SoporteParaConfiguracion.LeerConfiguracion() + @"\Morse\" + nombreArchivo;


            CrearArchivoTexto(rutaArchivo, cadena_morse);

            return rutaArchivo;
        }

        public static string LeerArchivoMorse(string ruta_archivo_morse)
        {
            string texto_morse = File.ReadAllText(ruta_archivo_morse);
            string texto_castellano = MorseATexto(texto_morse);


            //Crear directorio Morse, a menos que ya exista
            try
            {
                Directory.CreateDirectory(SoporteParaConfiguracion.LeerConfiguracion() + @"\Morse");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: {0}", ex);
                throw;
            }

            //Preparar string de ruta de archivo
            string rutaArchivo;
            string nombreArchivo;

            nombreArchivo = "texto_" + DateTime.Now.ToString() + ".txt";
            nombreArchivo = nombreArchivo.Replace('/', '-');
            nombreArchivo = nombreArchivo.Replace(' ', '_');
            nombreArchivo = nombreArchivo.Replace(':', '-');

            rutaArchivo = SoporteParaConfiguracion.LeerConfiguracion() + @"\Morse\" + nombreArchivo;


            CrearArchivoTexto(rutaArchivo, texto_castellano);

            return rutaArchivo;
        }


        public static void CrearArchivoTexto(string rutaArchivo, string texto_a_escribir)
        {
            try
            {
                File.WriteAllText(rutaArchivo, texto_a_escribir);
                Console.WriteLine("Archivo de texto creado exitosamente en {0}", rutaArchivo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: {0}", ex);
                throw;
            }
        }

        public static void CrearAudio(string ruta_archivo_morse)
        {
            byte[] audio_punto;
            byte[] audio_raya;
            byte[] audio_silencio;
            string directorio = SoporteParaConfiguracion.LeerConfiguracion();

            //Obtener arrays de audio punto y raya
            FileStream origen_punto = File.OpenRead(directorio + @"\" + "punto.mp3");
            FileStream origen_raya = File.OpenRead(directorio + @"\" + "raya.mp3"); 
            FileStream origen_silencio = File.OpenRead(directorio + @"\" + "silencio.mp3");

            audio_punto = LectorCompletoDeBinario(origen_punto);
            audio_raya = LectorCompletoDeBinario(origen_raya);
            audio_silencio = LectorCompletoDeBinario(origen_silencio);
            origen_punto.Close();
            origen_raya.Close();
            origen_silencio.Close();

            //Crear directorio Morse, a menos que ya exista
            try
            {
                Directory.CreateDirectory(SoporteParaConfiguracion.LeerConfiguracion() + @"\Morse");
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: {0}", ex);
                throw;
            }

            //Preparar string de ruta de archivo final
            string ruta_audio_morse;
            string nombreArchivo;

            nombreArchivo = "audio_" + DateTime.Now.ToString() + ".mp3";
            nombreArchivo = nombreArchivo.Replace('/', '-');
            nombreArchivo = nombreArchivo.Replace(' ', '_');
            nombreArchivo = nombreArchivo.Replace(':', '-');

            ruta_audio_morse = directorio + @"\Morse\" + nombreArchivo;

            FileStream Destino = new FileStream(ruta_audio_morse, FileMode.Create);

            List<byte> Lista_aux = new List<byte>();

            foreach (char caracter in File.ReadAllText(ruta_archivo_morse))
            {
                if (caracter == '.')
                {
                    Lista_aux.AddRange(audio_punto);
                    //Destino.Write(audio_punto, 0, audio_punto.Length);
                }
                else if (caracter == '-')
                {
                    Lista_aux.AddRange(audio_raya);
                    //Destino.Write(audio_raya, 0, audio_raya.Length);
                }
                else if (caracter == ' ')
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Lista_aux.AddRange(audio_silencio);
                    }
                }
                else if (caracter == '/')
                {
                    for (int i = 0; i < 7; i++)
                    {
                        Lista_aux.AddRange(audio_silencio);
                    }
                }

                Lista_aux.AddRange(audio_silencio);
            }
            Destino.Write(Lista_aux.ToArray(), 0, Lista_aux.Count);
            Destino.Close();

            Console.WriteLine("Archivo de audio creado exitosamente en {0}", ruta_audio_morse);
        }

        public static byte[] LectorCompletoDeBinario(Stream stream)
        {
            byte[] buffer = new byte[32768];
            using (MemoryStream ms = new MemoryStream()) // creando un memory stream 
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length); // lee desde la última posición hasta el tamaño del buffer
                    if (read <= 0)
                        return ms.ToArray(); // convierte el stream en array 
                    ms.Write(buffer, 0, read); // graba en el stream 
                }
            }
        }


    }
}
