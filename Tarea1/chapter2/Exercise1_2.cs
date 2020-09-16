using System;

public class Exercise1_2
{
    public Exercise1_2()
    {
        Console.WriteLine("Digite los lados que tiene el poligono: ");
        double sides = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite la longitud: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("El perimetro del poligono es: " + (sides * length));

    }
}

