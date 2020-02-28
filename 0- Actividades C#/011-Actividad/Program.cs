using System;

namespace Actividad_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se debe leer 10 números pedidos por teclado, 
             * almacenarnos en un array / matriz / vector / arreglo
             * (usando un for) y posteriomente mostrarlos. 
             * Añadido: Se debe almacenar y mostrar la suma y multiplicación de todos.
             * Añadido: Se debe mostrar el número mayor y el menor, leyéndolos desde la matriz.*/



            /* jcfm001. 20200228 Definimos la matriz.
             * jcfm002. 20200228 Iniciamos bucle para introducción de números.
             * jcfm003. 20200228 Asignamos como mayor y menor el primer elemento de la lista para que haya un elemento de comparación
             * jcfm004. 20200228 Iniciamos la presentación de la lista.
             */


            // jcfm001.
            double[] mat = new double[10];
            double suma = 0, mult1 = 1, may, men;

            Console.WriteLine("\n\n\n\t\tVamos a introducir una lista de 10 números. Posteriormente los mostrare en una lista.");

            // jcfm002.
            for (int i = 0; i < 10; i++)
            {

                Console.Write("\t\tPor favor introduzca el número que va en el puesto Nro. " + i + ": ");
                mat[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("\n\nPulse una tecla para continuar.");
            Console.ReadKey();

            // jcfm003.
            may = mat[1];
            men = mat[1];

            // jcfm004.
            Console.Clear();
            Console.WriteLine("\n\t\tLos datos introducidos son:\n");
            Console.WriteLine("\t\tPosición de lista\t\tOrden de introducción\t\tValor\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("\t\t\t" + (i) + "\t\t\t\t" + (i + 1) + "\t\t\t" + mat[i]);
                suma = suma + mat[i];
                mult1 = mult1 * mat[i];
                if (mat[i]>may)
                {
                    may = mat[i];
                }
                if (mat[i]<men)
                {
                    men = mat[i];
                }
            }
            Console.WriteLine("\n\t\t\tLa suma de los números introducidos es: "+suma);
            Console.WriteLine("\t\t\tLa multiplicación de los números introducidos es: " + mult1);
            Console.WriteLine("\t\t\tEl mayor de los números introducidos es: " + may);
            Console.WriteLine("\t\t\tEl menor de los números introducidos es: " + men);
            Console.WriteLine("\n\nPulse una tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
