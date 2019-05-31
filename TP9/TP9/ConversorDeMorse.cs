using System;
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
    }
}
