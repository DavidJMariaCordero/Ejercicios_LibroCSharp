using System;
public class Exercise8_5
{

    private string[] cadenas;
    public Exercise8_5()
    {
        Inicializar();
    }

    public void Inicializar(){

        cadenas = new string[2];
        solicitarCadenas();

        if(String.Compare(cadenas[0], cadenas[1]) == 1)
            Console.WriteLine("Las cadenas son iguales");
        else
            Console.WriteLine("Las cadenas son diferentes");
        
    }

    public void solicitarCadenas(){
        
        Console.WriteLine("Ingrese la primera cadena: ");
        this.cadenas[0] = Console.ReadLine();

        Console.WriteLine("Ingrese la segunda cadena: ");
        this.cadenas[1] = Console.ReadLine();
    }

     
    

}