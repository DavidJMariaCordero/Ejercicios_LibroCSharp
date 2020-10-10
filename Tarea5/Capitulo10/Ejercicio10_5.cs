using System;
public class Ejercicio10_5
{

    public int lado { get; set; }   
    public int longitud { get; set; }

    public Ejercicio10_5(){
        this.lado = 0;
        this.longitud = 0;
    }

    public Ejercicio10_5(int lado, int longitud){
        this.lado = lado;
        this.longitud = longitud;
    }

    public int poligono(int lado, int longitud){
        int perimetro = 0;
        if(lado < 0 || longitud < 0)
            Console.WriteLine("Debe ingresar datos validos");
        else
            perimetro = longitud * lado;
        

        return perimetro;
    }
    public int poligono(){
        int perimetro = 0;
        if(this.lado < 0 || this.longitud < 0)
            Console.WriteLine("Debe ingresar datos validos");
        else
            perimetro = this.longitud * this.lado;
      

        return perimetro;
    }
    public override string ToString()
    {
        return "El perimetro es: " + poligono();
    }
}