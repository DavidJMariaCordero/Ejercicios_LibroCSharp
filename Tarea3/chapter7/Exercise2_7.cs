using System;
using System.Collections;

public class Exercise2_7
{
    Hashtable Diccionario = new Hashtable();
    public Exercise2_7()
    {
        Inicializar();
    }
    void Inicializar()
    {
        Adding();
        Print();
    }

    public void Adding(){
        Diccionario.Add("Fuerza", "Capacidad física para realizar un trabajo o un movimiento.");
        Diccionario.Add("Limon", "Fruto del limonero, comestible, de forma ovalada, piel de color amarillo o verde y pulpa dividida en gajos, de sabor ácido y muy aromático.");
        Diccionario.Add("Casa", "Construcción cubierta destinada a ser habitada.");
        Diccionario.Add("Huevo", "Huevo que ponen las aves, especialmente la gallina, y que se toma como alimento.");
        Diccionario.Add("Leche", "Sustancia líquida y blanca que segregan algunos vegetales, como la higuera.");
        Diccionario.Add("Amor", "Sentimiento de vivo afecto e inclinación hacia una persona o cosa a la que se le desea todo lo bueno.");
    }

    public void Print(){
        foreach (DictionaryEntry datos in Diccionario)
            Console.WriteLine($"{datos.Key}: {datos.Value}");
    }

}