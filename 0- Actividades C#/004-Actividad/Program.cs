using System;

namespace suma1000
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Usar la estructura "for" para sumar los 1000 primeros números enteros, 
             * empezando por el 1000 y terminando por el 1, es decir: 
             * 1000 + 999 + 998+...+ 1, mostrando el resultado.*/

            int sum = 0;

            for (int i = 1000; i > 0; i--)
            {
                sum = sum + i;
                Console.WriteLine(i);
            }
            Console.WriteLine("El resultado de la suma de los números anteriones es: "+sum);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("************* GRACIAS POR USAR ESTE SOFTWARE ***************");
            Console.ReadKey();
        }
    }
}
