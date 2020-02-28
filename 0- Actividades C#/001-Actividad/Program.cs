using System;

namespace act1_de_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Pedir tres valores numéricos, para luego mostrar 
            por pantalla el mayor y el menor, 
            y calcular  el valor de la suma, la resta, 
            la multiplicación y la división de estos dos.*/

            // Declarar las variables e inicializar valores.

            int elem = 0;
            double may = 0;
            double men = 0;
            double sum = 0;
            double res = 0;
            double mul = 0;
            double div = 0;
            string cont = "s";

            // Iniciamos un bucle para ejecutar varias veces.

            while (cont != "N")
            {
                // Borramos la pantalla.
                Console.Clear();
                // Pedimos los valores.
                Console.WriteLine("Por favor introduzca una lista con varios números, hallaré el mayor y el menor, luego haré las operaciones básicas con los dos.");
                Console.WriteLine("¿Cuántos elementos tiene la lista de números?");
                elem = Convert.ToInt16(Console.ReadLine());
                int[] num = new int[(elem)];
                // Bucle para la toma de valores.
                for (int i = 0; i < (elem); i++)
                {
                    Console.WriteLine("Cual es el valor del " + (i + 1) + "º");
                    num[i] = Convert.ToInt32(Console.ReadLine());

                }
                // Fijamos el número menor a uno de los de la lista para que lo compare, de lo contratio su valor será 0.
                men = num[0];
                // Ordenamos los números con bucle de ordenación.
                for (int i = 0; i < (elem); i++)
                {
                    if (num[i] > may)
                    {
                        may = num[0];
                    }
                    if (num[i] < men)
                    {
                        men = num[i];
                    }
                }

                // Hacemos las operaciones. La división tiene una condición: el número menor es  diferente de cero.
                sum = may + men;
                res = may - men;
                mul = may * men;
                if (men != 0)
                {
                    div = may / men;
                }
                // Borramos pantalla y presentamos resultados.
                Console.Clear();
                Console.WriteLine("El número mayor es :" + may + " y el número menor es: " + men);
                Console.WriteLine("El resultado de la suma es: " + sum);
                Console.WriteLine("El resultado de la resta es: " + res);
                Console.WriteLine("El resultado de la multiplicación es: " + mul);
                if (men == 0)
                {
                    Console.WriteLine("La división no se puede efectuar porque el divisor es " + men);
                }
                else
                {
                    Console.WriteLine("El resultado de la división es: " + div);
                }
                Console.WriteLine("Si desea continuar pulse cualquier tecla, para salir pulse N.");
                cont = Console.ReadLine();
                if (cont == "n")
                {
                    cont = "N";
                }




            }


        }
    }
}
