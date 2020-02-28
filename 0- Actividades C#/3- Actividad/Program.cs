using System;

namespace contador
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Usar la estructura "for" que repita 10 veces la frase 
             * "Introduzca un número entero" para posteriormente realizar 
             * la media de esos números.*/

            // Iniciamos variable.
            double sum = 0;

            // Pedimos lños números.
            Console.WriteLine("Introduzca una serie de diez números enteros para posteriormente realizar la media de esos números.");
            for (int i = 1; i < 11;i++)
            {
                Console.WriteLine(i+" Introduzca un número");
                sum = sum + Convert.ToDouble(Console.ReadLine());
                             
            }
            // Presenta los resultados.
            Console.Clear();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(" la media es :"+(sum/10));
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("********* Su colaboración es muy apreciada ***************");


            // Pausa el cierre de la ventana.
            Console.ReadKey();
        }
    }
}
