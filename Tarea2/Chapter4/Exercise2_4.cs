using System;
public class Exercise2_4{
    private int number;
    private int power;

    public Exercise2_4(){
        this.number = 0;
        this.power = 0;
        Inicializar();
    }

    public void Inicializar(){
        Console.WriteLine("Digite el numero del cual desea potenciar: ");
        number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite la potencia: ");
        power = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"{number}^{power} = {Math.Pow(number, power)}");
        
    }

}