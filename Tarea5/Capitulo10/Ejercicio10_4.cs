using System;
public class Ejercicio10_4
{

    public int lado { get; set; }   
    public int longitud { get; set; }

    public Ejercicio10_4(){
        this.lado = 0;
        this.longitud = 0;
    }

    public Ejercicio10_4(int lado, int longitud){
        this.lado = lado;
        this.longitud = longitud;
    }

    public int poligono(int lado, int longitud){
        int perimetro = 0;
        if(lado < 0 || longitud < 0)
            Console.WriteLine("Debe ingresar datos validos");
        else{
            perimetro = longitud * lado;
        }

        return perimetro;
    }
    
}