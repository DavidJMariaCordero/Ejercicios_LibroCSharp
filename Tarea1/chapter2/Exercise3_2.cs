using System;

public class Exercise3_2
{
    public Exercise3_2()
    {
        Console.Write("Digite los grados: ");
        double number = Convert.ToDouble(Console.ReadLine());
        if (number < 0)
            Console.WriteLine("Ha ingresado un número invalido");
        else
            Console.WriteLine("El número " + number + " en radianes es: " + (number * 3.1416) / 180);
    }
}

