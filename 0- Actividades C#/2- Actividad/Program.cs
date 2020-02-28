using System;

namespace uso_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            
                /* Pedir un número del 1 al 12 por teclado para luego 
                indicar el nombre del mes correspondiente
                (usando la estructura de control "switch - case - default"). */

                // Definimos y declaramos variables y constantes.

            string ene = "Enero", feb = "Febrero", mar = "Marzo", abr = "Abril";
            string may = "Mayo", jun = "Junio", jul = "Julio", ago = "Agosto";
            string sep = "Septiembre", oct = "Octubre", nov = "Noviembre", dic = "Diciembre";
            string mes = "";
            int num = 0;

            while ((num < 1) || (num > 12))
            {
                Console.Clear();
                Console.WriteLine("Por favor introduzca un número entre 1 y 12 y le diré a que mes corresponde: ");
                num = Convert.ToByte(Console.ReadLine());
            }
            switch (num)
            {
                case 1:
                    mes = ene;
                    break;
                case 2:
                    mes = feb;
                    break;
                case 3:
                    mes = mar;
                    break;
                case 4:
                    mes = abr;
                    break;
                case 5:
                    mes = may;
                    break;
                case 6:
                    mes = jun;
                    break;
                case 7:
                    mes = jul;
                    break;
                case 8:
                    mes = ago;
                    break;
                case 9:
                    mes = sep;
                    break;
                case 10:
                    mes = oct;
                    break;
                case 11:
                    mes = nov;
                    break;
                case 12:
                    mes = dic;
                    break;
                default:
                    break;
            }
            Console.Clear();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("El número que Ud. ha selecionado corresponde al mes de: " + mes);
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("*************Gracias por comprar nuestro software******************");
            Console.ReadKey();


        }
    }
}
