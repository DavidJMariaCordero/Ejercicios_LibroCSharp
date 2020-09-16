using System;

public class Exercise4_2
{
    public Exercise4_2()
    {
        Console.Write("Digite los grados Celsius: ");
        double number = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Grados Celsius " + number + " en grados Fahrenheit es: " + (((number * 9) / 5) + 32));

    }
}
