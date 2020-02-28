using System;

namespace tabla_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
			/* Mostrar las tablas de multiplicar desde la del 1 hasta la del 10, es decir, al ejecutar la aplicación se deberá visualizar lo siguiente:
			 * TABLAS DE MULTIPLICAR:
			 * 1 * 0 = 0
			 * 1 * 1 = 1
			 * .
			 * .
			 * .
			 * .
			 * 2 * 0 = 0
			 * 2 * 1 = 2
			 * .
			 * .
			 * .
			 * 10 * 10 = 100. */

			// Mostrar las tablas de multiplicar.

			Console.Clear();

			for (int i = 1; i <11; i++)
			{
				for (int i2 = 0; i2 <11; i2++)
				{
					Console.WriteLine("        "+i + " * " + i2 + " = " + (i2 * i) + ".");
				}
				if (i<10)
				{
					Console.WriteLine("        .");
					Console.WriteLine("        .");
					Console.WriteLine("        .");
					Console.WriteLine("        .");
				}
				
			}
			Console.WriteLine("\n\n\n");
			Console.WriteLine("$$$$$$$$$$$$$$ GRACIAS POR UTILIZAR NUESTRA APLICACIÓN. $$$$$$$$$$$$$$$$");
			Console.ReadKey();
        }
    }
}
