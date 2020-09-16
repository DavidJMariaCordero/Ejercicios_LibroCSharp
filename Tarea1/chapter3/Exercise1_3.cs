using System;
public class Exercise1_3
{
    public Exercise1_3()
    {
        Console.Write("Digite un número: ");

        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
            Console.WriteLine("El numero " + number + " es par");
        else
            Console.WriteLine("El numero " + number + " es impar");
    }

}
