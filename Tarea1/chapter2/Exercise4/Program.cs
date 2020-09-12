using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite los grados Celsius: ");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Grados Celsius " + number + " en grados Fahrenheit es: " + (((number * 9) / 5) + 32));
        }
    }
}
