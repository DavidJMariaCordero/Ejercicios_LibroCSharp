using System;
using System.Collections;

public class Exercise1_7{
        float suma = 0.0f;
        float promedio = 0.0f;
        float minima = 0.0f; 
        float mayor = 0.0f; 
        ArrayList calif = new ArrayList();
    public Exercise1_7(){
        Inicializar();
    }
    void Inicializar(){
        PedirCalificaciones();
        Promedio();
        NotaMenor();
        NotaMayor();
        Imprimir();
    }
    public void NotaMayor(){
        mayor = Convert.ToSingle(calif[0]);
        for(int n = 0; n < calif.Count; n++) 
        {
            if(Convert.ToSingle(calif[n]) > mayor)
                mayor = Convert.ToSingle(calif[n]);
              
        }
    }

    public void NotaMenor(){
        minima = Convert.ToSingle(calif[0]);
        for(int n = 0; n < calif.Count; n++) 
        {
            if(Convert.ToSingle(calif[n]) < minima)
                minima = Convert.ToSingle(calif[n]);
              
        }
    }

    public void Promedio(){
        suma = 0;
        for(int n = 0; n < calif.Count; n++) 
            suma += Convert.ToSingle(calif[n]); 
            
        promedio = suma/calif.Count; 
    }

    public void Imprimir(){
        Console.WriteLine($"La nota minima es: {minima}");
        Console.WriteLine($"La nota maxima es: {mayor}");
        Console.WriteLine($"El promedio es: {promedio}");
    }
    public void PedirCalificaciones(){
        Console.WriteLine("Digite la cantidad de alumnos: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        
        for (int n = 0; n < cantidad; n++) 
        {
            Console.Write("Dame la calificación: ");
            calif.Add(Convert.ToSingle(Console.ReadLine()));
            
        }
    }
}