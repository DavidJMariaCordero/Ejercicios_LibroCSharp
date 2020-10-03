/*Crear una enumeración para los
diferentes tipos de neumáticos.*/
using System;
public class Exercise9_4
{
    enum Neumaticos {Duro, Medio, Intermedios, Blando, Lluvia};
    Neumaticos neumaticos;
    public Exercise9_4()
    {
        neumaticos = Neumaticos.Blando;
        Console.WriteLine(neumaticos.ToString());
    }

}
