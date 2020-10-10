using System;
public class Ejercicio12_1
{
    public int numero { get; set; }
    public Ejercicio12_1()
    {
        Console.WriteLine("Digite un numero: ");
        numero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"El factorial del numero {numero} es {factorial(numero)}");
    }

    public static int factorial(int numero)
    {
        int factor = 1;

        for (int i = numero; i > 1; i--)
            factor *= i;
            
        return factor;
    }
}    