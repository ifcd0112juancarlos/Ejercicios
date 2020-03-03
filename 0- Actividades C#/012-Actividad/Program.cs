using System;

namespace _012_Actividad
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Se debe leer 10 números pedidos por teclado, 
             * almacenarnos en un array/matriz/vector/arreglo 
             * (usando un for) y posteriomente pida una opción
             * (Suma, Resta, Multiplicación o División). Tras 
             * esto pedirá 2 posiciones de dicho vector, y 
             * realizará la operación seleccionada. Se debe 
             * repetir la petición  de la operación hasta que 
             * el usuario decida salir (siempre a partir de 
             * la matriz original). */

            // Estas instrucciones obtienen los valores máximos para el ancho "ww" (window widht)
            // y el alto "wh" (window height) de la ventana en donde se ejecutará la aplicación, 
            // fijan la ventana a ese tamaño y modifican el título de la ventana.

            int ww = Console.LargestWindowWidth;
            int wh = Console.LargestWindowHeight;

            Console.SetWindowSize(ww, wh);
            Console.SetWindowPosition(0, 0);
            Console.Title = "Actividad 12 del curso de Programación Orientada a Objetos";

            // Definimos variables y matriz.

            double[] m = new double[10];
            int pri = 0, seg = 0;
            Double res = 0;
            char repeat = 's', op = ' ';

            // Bucle para la carga de los datos

            for (int i = 0; i < 10; i++)
            {


                Console.Clear();
                Console.WriteLine("\n\n\tSe deben introducir 10 números enteros, los cuales serán");
                Console.WriteLine("\talmacenados en orden, posteriormente usted señalará que ");
                Console.WriteLine("\toperación desea realizar entre  dos posiciones, así hasta ");
                Console.WriteLine("\tque decida salir.");
                Console.Write("\n\n\tIntroduzca el Número que va en la posición " + (i + 1) + ": ");
                m[i] = Convert.ToInt32(Console.ReadLine());

            }

            // Bucle para la presentación del Array , solicitud de tipo de operación y posición
            // de los elementos sobre los cuales se va a operar.

            while (repeat == 's')
            {
                Console.Clear();
                Console.WriteLine("\n\n\tPosición de los números introducidos:\n\n");
                Console.WriteLine("\tPosición: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\t" + (i + 1) + "\t||");
                }
                Console.WriteLine("\n\n\tNúmeros: ");
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("\t" + m[i] + "\t||");
                }
                Console.WriteLine("\n\n\n\tAhora, por favor, indique el tipo de operación a efectuar: ");
                Console.WriteLine("\n\n\t1.-\tSuma.");
                Console.WriteLine("\n\t2.-\tResta.");
                Console.WriteLine("\n\t3.-\tMultiplicación.");
                Console.WriteLine("\n\t4.-\tDivisión.");
                Console.Write("\n\n\t¿Qué operación desea realizar? ");
                op = Convert.ToChar(Console.ReadLine());
                Console.Write("\n\n\t¿Cuál es la posición del primer número? ");
                pri = (Convert.ToInt16(Console.ReadLine()) - 1);
                Console.Write("\n\n\t¿Cuál es la posición del segundo número? ");
                seg = (Convert.ToInt16(Console.ReadLine()) - 1);
                switch (op)
                {
                    case '1':
                        res = m[pri] + m[seg];
                        break;
                    case '2':
                        res = m[pri] - m[seg];
                        break;
                    case '3':
                        res = m[pri] * m[seg];
                        break;
                    case '4':
                        if (m[seg] != 0)
                        {
                            res = m[pri] / m[seg];
                        }

                        break;
                    default:
                        break;
                }
                // Presentación de resultados y pregunta si desea realizar otra operación.
                // Console.Clear();
                if (m[seg] == 0 && op == '4')
                {
                    Console.Write("\n\n\n\tEl resultado de su operación no se puede mostrar. No se puede" +
                        " dividir entre 0");
                }
                else
                {
                    Console.Write("\n\n\n\tEl resultado de su operación es: " + res);
                }

                Console.Write("\n\n\n\tDesea hacer otra operación (S/n): ");
                repeat = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                //Console.ReadKey();

            }
            Console.WriteLine("\n\n**********  Gracias por usar este software. ************\n\n");
            Console.WriteLine(" /$$$$$$$$ /$$                           /$$                        /$$$$$$                           ");
            Console.WriteLine("|__  $$__/| $$                          | $$                       /$$__  $$                          ");
            Console.WriteLine("   | $$   | $$$$$$$   /$$$$$$  /$$$$$$$ | $$   /$$  /$$$$$$$      | $$  \\__/  /$$$$$$   /$$$$$$       ");
            Console.WriteLine("   | $$   | $$__  $$ |____  $$| $$__  $$| $$  /$$/ /$$_____/      | $$$$     /$$__  $$ /$$__  $$ ");
            Console.WriteLine("   | $$   | $$  \\ $$  /$$$$$$$| $$  \\ $$| $$$$$$/ |  $$$$$$       | $$_/    | $$  \\ $$| $$  \\__/");
            Console.WriteLine("   | $$   | $$  | $$ /$$__  $$| $$  | $$| $$_  $$  \\____  $$      | $$      | $$  | $$| $$   ");
            Console.WriteLine("   | $$   | $$  | $$|  $$$$$$$| $$  | $$| $$ \\  $$ /$$$$$$$/      | $$      |  $$$$$$/| $$ ");
            Console.WriteLine("   |__/   |__/  |__/ \\_______/|__/  |__/|__/  \\__/|_______/       |__/       \\______/ |__/ ");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("                                                     /$$");
            Console.WriteLine("                                                    | $$");
            Console.WriteLine("  /$$$$$$$ /$$   /$$  /$$$$$$   /$$$$$$   /$$$$$$  /$$$$$$         /$$   /$$  /$$$$$$$");
            Console.WriteLine(" /$$_____/| $$  | $$ /$$__  $$ /$$__  $$ /$$__  $$|_  $$_/        | $$  | $$ /$$_____/");
            Console.WriteLine("|  $$$$$$ | $$  | $$| $$  \\ $$| $$  \\ $$| $$  \\__/  | $$          | $$  | $$|  $$$$$$");
            Console.WriteLine(" \\____  $$| $$  | $$| $$  | $$| $$  | $$| $$        | $$ /$$      | $$  | $$ \\____  $$ ");
            Console.WriteLine(" /$$$$$$$/|  $$$$$$/| $$$$$$$/|  $$$$$$/| $$        |  $$$$/      |  $$$$$$/ /$$$$$$$/ /$$");
            Console.WriteLine("|_______/  \\______/ | $$____/  \\______/ |__/         \\___/         \\______/ |_______/ |__/ ");
            Console.WriteLine("                    | $$  ");
            Console.WriteLine("                    | $$ ");
            Console.WriteLine("                    |__/");




            Console.ReadKey();
        }
    }
}
