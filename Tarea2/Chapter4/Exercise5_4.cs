using System;
public class Exercise5_4
{
    private int old;
    private int young;
    private int average;
    private int quantity;
    private int age;

    public Exercise5_4(){
        old = young = average = quantity = age = 0;
        Inicializar();
    }

    public void Inicializar()
    {
        Console.WriteLine("Cuantas personas va a evaluar? ");
        quantity = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < quantity; i++)
        {
            Console.WriteLine($"{i+1}: Digite la edad: ");
            age = Convert.ToInt32(Console.ReadLine());

            if (i == 0)
            old = young = age;
            if (age < young)
                young = age;
            if(age > old)
                old = age;
                
            average += age;

        }
        Console.WriteLine($"El promedio de las edades es: {average/quantity}");
        Console.WriteLine($"La edad mas joven es: {young}");
        Console.WriteLine($"La edad mas grande es: {old}");
    }
}