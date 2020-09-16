using System;
public class Exercise1_4{
    private int number;

    public Exercise1_4(){
        this.number = 0;
        Inicializar();
    }

    public void Inicializar(){
        Console.WriteLine("Digite el numero del cual desea obtener la tabla de multiplicacion: ");
        number = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
            Console.WriteLine($"{i} X {number} = {number*i}");
        
    }

}