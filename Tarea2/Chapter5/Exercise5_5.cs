using System;
public class Exercise5_5
{
    private int number;
    private string NumberLetter;

    public Exercise5_5()
    {
        Inicializar();

    }
    public string numeros()
    {
        switch (number)
        {
            case 1:
                NumberLetter = "UNO";
                break;
            case 2:
                NumberLetter = "DOS";
                break;
            case 3:
                NumberLetter = "TRES";
                break;
            case 4:
                NumberLetter = "CUATRO";
                break;
            case 5:
                NumberLetter = "CINCO";
                break;
            case 6:
                NumberLetter = "SEIS";
                break;
            case 7:
                NumberLetter = "SIETE";
                break;
            case 8:
                NumberLetter = "OCHO";
                break;
            case 9:
                NumberLetter = "NUEVE";
                break;
            case 10:
                NumberLetter = "DIEZ";
                break;
            default:
                Console.WriteLine("Error");
                break;

        }
        return NumberLetter;
    }

    public void Inicializar()
    {
        number = 0;
        NumberLetter = "";
        Console.WriteLine("Digite un numero del 1 al 10: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number > 10 || number < 1)
            Console.WriteLine("Ha ingresado un numero no valido");
        else
            Console.WriteLine($"El numero {number} es {numeros()}");


    }
}