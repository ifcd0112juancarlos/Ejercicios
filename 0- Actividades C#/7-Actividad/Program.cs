using System;

namespace Actividad_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se debe realizar en C# la siguiente aplicación:
             * Mostrar las tablas de multiplicar empezando por la de X hasta la de Y, 
             * siendo X e Y las que el usario decida, es decir, si el usuario decide que 
             * empecemos desde el 3 y terminemos por la del 13, el resultado sería:
             * 
             * TABLAS DE MULTIPLICAR:
             *      3 * 0 = 0
             *      3 * 1 = 3
             *      .
             *      .
             *      .
             *      .
             *      4 * 0 = 0
             *      4 * 1 = 4
             *      .
             *      .
             *      .
             *      13 * 10 = 130. */

            // Declaramos variables. 
            Int32 num1 = 0, num2 = 0, aux = 0;


            // Mostrar las tablas de multiplicar.

            Console.Clear();
            Console.WriteLine("\n\n\n    Hola, vamos a presentar varias tablas de multiplicar consecutivas, entre");
            Console.WriteLine("    dos números que usted nos suministre.");
            Console.Write("\n\n\n    Por favor ingrese el primer número desde el cuál desee generar las tablas: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n\n    Por favor ingrese el último número hasta el cuál desee generar las tablas: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\n\n");

            if (num1>num2)
            {
                aux = num1; num1 = num2;num2 = aux;
            }
            for (int i = num1; i < num2+1; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    Console.WriteLine("        " + i + " * " + i2 + " = " + (i2 * i) + ".");
                }
                if (i < 10)
                {
                    Console.WriteLine("        .");
                    Console.WriteLine("        .");
                    Console.WriteLine("        .");
                    Console.WriteLine("        Presione cualquier tecla para continuar:");
                    Console.ReadKey();
                }

            }
            Console.WriteLine("\n\n\n");
            Console.WriteLine("$$$$$$$$$$$$$$ GRACIAS POR UTILIZAR NUESTRA APLICACIÓN. $$$$$$$$$$$$$$$$");
            Console.ReadKey();
        }
    }
}
