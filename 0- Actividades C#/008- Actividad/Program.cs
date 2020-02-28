using System;

namespace actividad_8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Usar la/s estructura/s "while" para mostrar una frase en la que le pida al usuario 
             * la introducción de un nuevo número decimal, y vaya sumándolos hasta que el usuario 
             * decida no continuar al responder a la pregunta 
             * “¿Desea continuar con el sumatorio(S/N)?” . Finalmente debe mostrar el resultado de la suma total. */

            // Declaramos e inicializamos variables.
            
            double sum = 0, aux = 0;
            string cont = "", num = "";

            // Cambiamos color de fondo y fuentes;

            Console.ForegroundColor = ConsoleColor.Green;

            // Explicamos como funciona el programa.

            Console.WriteLine("\n\n\n\tEl presente programa irá sumando los números introducidos por el usuario,");
            Console.WriteLine("\tincluso decimales hasta que decida introducir la letra \"n\"");
            Console.WriteLine("\tpara indicar que no desea seguir añadiendo números\n\n\n");

            // Iniciamos bucle para la introducción de los números.
            
            while (cont!="n")
            {
                // Pedimos el número.
                
                Console.Write("\tPor favor introduzca un número (\"n\" para salir): ");
                num = Console.ReadLine();

                // Comprobamos que el usuario no desea salir.

                if (num.ToUpper()=="N")
                {
                    cont = "n";
                }
                else
                {
                    // Con esta instrucción comprobamos que sea un número.
                    
                    bool flag = double.TryParse(num, out aux);

                    // Si no es un número muestra el mensaje.
                    if (!flag)
                    {
                        Console.WriteLine("\n\n\n\tNo has ingresado un número, inténtalo de nuevo.");
                    }
                    else
                    {
                        // Se suma el número.
                        sum = sum + aux;
                    }

                }
                
            }

            // Muestra el resultado.
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n\n\n\tEl resultado es: " + sum);

            // Espera para cerrar ventana.
            Console.ReadKey();

            
        }

    }
}
