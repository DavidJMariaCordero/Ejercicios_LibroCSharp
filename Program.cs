using System;

namespace Ejercicios_LibroCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ejercicios();

                Console.WriteLine("Presione la tecla [BackSpace] Para salir, si desea continuar pulse cualquier letra... ");
            } while (Console.ReadKey().Key != ConsoleKey.Backspace);

        }

        public static void ejercicios()
        {
            Console.Clear();
            Console.WriteLine("Digite 1 para acceder a los ejercicios de la TAREA 1 \nDigite 2 para acceder a los ejercicios de la TAREA 2 \nDigite 3 para acceder a los ejercicios de la TAREA 3\nDigite 4 para acceder a los ejercicios de la TAREA4\nDigite 5 para acceder a los ejercicios de la TAREA5");
            Console.WriteLine("Digite su opcion: ");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Tarea1();
                    break;
                case 2:
                    Tarea2();
                    break;
                case 3:
                    Tarea3();
                    break;
                case 4:
                    Tarea4();
                    break;
                case 5:
                    Tarea5();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;

            }

        }

        public static void Tarea1()
        {
            Console.Clear();
            switch (ListaTarea1())
            {
                case 1:
                    new Exercise1_1();
                    break;
                case 2:
                    new Exercise5_1();
                    break;
                case 3:
                    new Exercise1_2();
                    break;
                case 4:
                    new Exercise3_2();
                    break;
                case 5:
                    new Exercise4_2();
                    break;
                case 6:
                    new Exercise5_2();
                    break;
                case 7:
                    new Exercise1_3();
                    break;
                case 8:
                    new Exercise4_3();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }

        }
        public static void Tarea2()
        {
            Console.Clear();
            switch (ListaTarea2())
            {
                case 1:
                    new Exercise1_4();
                    break;
                case 2:
                    new Exercise2_4();
                    break;
                case 3:
                    new Exercise5_4();
                    break;
                case 4:
                    new Exercise4_5();
                    break;
                case 5:
                    new Exercise5_5();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

        }

        public static void Tarea3()
        {
            Console.Clear();
            switch (ListaTarea3())
            {
                case 1:
                    new Exercise1_6();
                    break;
                case 2:
                    new Exercise2_6();
                    break;
                case 3:
                    new Exercise3_6();
                    break;
                case 4:
                    new Exercise4_6();
                    break;
                case 5:
                    new Exercise5_6();
                    break;
                case 6:
                    new Exercise1_7();
                    break;
                case 7:
                    new Exercise2_7();
                    break;
                case 8:
                    new Exercise5_7();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }

        }

        public static void Tarea4()
        {
            Console.Clear();
            switch (ListaTarea4())
            {
                case 1:
                    new Exercise8_3();
                    break;
                case 2:
                    new Exercise8_5();
                    break;
                case 3:
                    new Exercise9_1();
                    break;
                case 4:
                    new Exercise9_3();
                    break;
                case 5:
                    new Exercise9_4();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }

        }

        public static void Tarea5()
        {
            Console.Clear();
            switch (ListaTarea5())
            {
                case 1:
                    new Ejercicio10_1();
                    break;
                case 2:
                    new Ejercicio10_2();
                    break;
                case 3:
                    new Ejercicio10_3();
                    break;
                case 4:
                    new Ejercicio10_4();
                    break;
                case 5:
                    new Ejercicio10_5();
                    break;
                case 6:
                    new Ejercicio12_1();
                    break;
                case 7:
                    new Ejercicio12_2();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;

            }

        }

        public static int ListaTarea1()
        {
            Console.WriteLine("Digite 1 para ejecutar el Ejercicio1.1  \nDigite 2 para ejecutar el Ejercicio1.5 \nDigite 3 para ejecutar el Ejercicio2.1 \nDigite 4 para ejecutar el Ejercicio2.3 \nDigite 5 para ejecutar el Ejercicio2.4 \nDigite 6 para ejecutar el Ejercicio2.5 \nDigite 7 para ejecutar el Ejercicio3.1 \nDigite 8 para ejecutar el Ejercicio3.4");
            Console.WriteLine("Digite su opcion: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int ListaTarea2()
        {
            Console.WriteLine("Digite 1 para ejecutar el Ejercicio4.1  \nDigite 2 para ejecutar el Ejercicio4.2 \nDigite 3 para ejecutar el Ejercicio4.5 \nDigite 4 para ejecutar el Ejercicio5.4 \nDigite 5 para ejecutar el Ejercicio5.5");
            Console.WriteLine("Digite su opcion: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int ListaTarea3()
        {
            Console.WriteLine("Digite 1 para ejecutar el Ejercicio6.1  \nDigite 2 para ejecutar el Ejercicio6.2 \nDigite 3 para ejecutar el Ejercicio6.3 \nDigite 4 para ejecutar el Ejercicio6.4 \nDigite 5 para ejecutar el Ejercicio6.5 \nDigite 6 para ejecutar el Ejercicio7.1 \nDigite 7 para ejecutar el Ejercicio7.2 \nDigite 8 para ejecutar el Ejercicio7.5");
            Console.WriteLine("Digite su opcion: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int ListaTarea4()
        {
            Console.WriteLine("Digite 1 para ejecutar el Ejercicio8.3  \nDigite 2 para ejecutar el Ejercicio8.5 \nDigite 3 para ejecutar el Ejercicio9.1 \nDigite 4 para ejecutar el Ejercicio9.3 \nDigite 5 para ejecutar el Ejercicio9.4");
            Console.WriteLine("Digite su opcion: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int ListaTarea5()
        {
            Console.WriteLine("Digite 1 para ejecutar el Ejercicio10.1  \nDigite 2 para ejecutar el Ejercicio10.2 \nDigite 3 para ejecutar el Ejercicio10.3 \nDigite 4 para ejecutar el Ejercicio10.4 \nDigite 5 para ejecutar el Ejercicio10.5 \nDigite 6 para ejecutar el Ejercicio12.1 \nDigite 7 para ejecutar el Ejercicio12.2");
            Console.WriteLine("Digite su opcion: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
