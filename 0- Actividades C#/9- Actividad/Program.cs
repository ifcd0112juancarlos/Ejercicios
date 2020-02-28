using System;

namespace Actividad_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Usar las estructuras "While" y "Switch" para mostrar una frase 
             * en la que se pida por pantalla la introducción de una nueva letra 
             * y vaya diciendo si se corresponde con una vocal o no, hasta que 
             * el usuario decida no continuar respondiendo negativamente a la 
             * pregunta “¿Desea introducir una nueva letra(S / N) ?”. 
             * Finalmente se debe mostrar las tres cantidades siguientes: 
             * total de letras introducidas, las que fueron vocales y las que no. */

            // Declaramos variables.

            int contv = 0, cont = 0, contc = 0;
            char x;
            string ltr="";

            // Indicamos las instrucciones de lo que vamos a hacer.

            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\t\tIntroduzca un caracter y le diré si es vocal o no, ");
                Console.Write("\t\tasí como el número de letras introducidas, cuantas de ellas son vocales y cuantas no.\n\n\n") ;
                Console.Write("\t\t\tPor favor introduzca una letra: ");
                x = Convert.ToChar(Console.ReadLine());
                switch (x)
                {
                    case 'a':
                        contv++; cont++;
                        break;
                    case 'e':
                        contv++; cont++;
                        break;
                    case 'i':
                        contv++; cont++;
                        break;
                    case 'o':
                        contv++; cont++;
                        break;
                    case 'u':
                        contv++; cont++;
                        break;
                    default:
                        cont++;
                        break;
                }
                contc = cont - contv;
                do
                {


                    Console.WriteLine("\n\n\n\t\t\t¿Desea introducir una nueva letra(S / N) ?");
                    ltr = Console.ReadLine();

                } while (ltr.ToLower() != "s" && ltr.ToLower() != "n");

            } while (ltr.ToLower() != "n");
            Console.Clear();
            Console.WriteLine("\n\n\n\t\t\tUsted ha introducido "+cont+" letras, de las cuales "+contv+" son vocales y "+contc+" no lo son. ");
            Console.ReadKey();

        }
    }
}
