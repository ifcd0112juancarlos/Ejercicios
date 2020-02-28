using System;

namespace Actividad_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se debe leer 10 números pedidos por teclado, 
             * almacenarnos en un array / matriz / vector / arreglo
             * (usando un for) y posteriomente mostrarlos. */


            /* jcfm001. 20200228 Definimos la matriz.
             * jcfm002. 20200228 Iniciamos bucle para introducción de números.
             * jcfm003. 20200228 Iniciamos la presentación de la lista.
             */


            // jcfm001.
            double[] mat = new double[10];

            Console.WriteLine("\n\n\n\t\tVamos a introducir una lista de 10 números. Posteriormente los mostrare en una lista.");

            // jcfm002.
            for (int i = 0; i < 10; i++)
            {

                Console.Write("\t\tPor favor introduzca el número que va en el puesto Nro. " + i+ ": ");
                mat[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n\nPulse una tecla para continuar.");
            Console.ReadKey();
            // jcfm003.
            Console.Clear();
            Console.WriteLine("\n\t\tLos datos introducidos son:\n");
            Console.WriteLine("\t\tPosición de lista\t\tOrden de introducción\t\tValor\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\t\t\t"+(i)+"\t\t\t\t"+(i+1)+ "\t\t\t" + mat[i]+ "\n");
            }
            Console.WriteLine("\n\nPulse una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
