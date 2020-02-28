using System;

namespace suma1000mod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Se debe realizar en C# la siguiente aplicación:
             * Pedir un número inicial y otro número final. A partir de ahí, 
             * se debe usar la estructura "for" para sumar todos los números 
             * enteros que están comprendidos en el intervalo y mostrarlos 
             * (incluyendo a estos dos). Se debe recorrer los números de forma 
             * incremental o decremenal según corresponda, visualizando el 
             * resultado al final.
             * P.ej. Si los números introducidos son 7 y 3: 
             * 7  6  5  4  3 Resultado de la suma = 25
             * P.ej. Si los números introducidos son 3 y 6:  
             * 3  4  5  6  Resultado de la suma = 18.*/

            int sum = 0;
            int i = 0, fin = 0;

            Console.WriteLine("    El presente programa calcula la suma de la serie de números enteros consecutivos");
            Console.WriteLine("    entre dos números dados, bien sea esta serie progresiva o regresiva.");
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("    Indique el número inicial para el cálculo: ");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("    Indique el número final de la serie: ");
            fin = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (i > fin)

            {
                for (i = i; i > fin - 1; i--)
                {
                    sum = sum + i;
                    Console.WriteLine("        "+i);
                }

            }
            else
            {
                for (i = i; i < fin + 1; i++)
                {
                    sum = sum + i;
                    Console.WriteLine("        "+i);
                }


            }
            Console.WriteLine("    El resultado de la suma de los números anteriones es: " + sum);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("    ************* GRACIAS POR USAR ESTE SOFTWARE ***************");
            Console.ReadKey();
        }
    }
}
