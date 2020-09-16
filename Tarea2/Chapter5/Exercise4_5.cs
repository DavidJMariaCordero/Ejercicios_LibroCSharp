using System;
public class Exercise4_5
{
    private int number;
    private int result;
    public Exercise4_5()
    {
        Inicializar();

    }
    public int Factorial()
    {
        for (int i = 1; i <= number; i++)
            result *= i;
        return result;
    }

    public void Inicializar()
    {
        number = 0;
        result = 1;

        Console.WriteLine("Digite el numero: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"El factorial de {number} es: {Factorial()}");

    }
}