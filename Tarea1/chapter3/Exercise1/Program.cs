using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un número: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine("El numero " + number + " es par");
            else
                Console.WriteLine("El numero " + number + " es impar");
        }
    }
}
