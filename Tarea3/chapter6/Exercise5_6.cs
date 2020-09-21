using System;
public class Exercise5_6
{
    string[][] nombres;
    public Exercise5_6()
    {
        Inicializar();
    }

    public void Inicializar()
    {
        nombres = new string[][] { new string[] { "pancho", "papolo", "Roberto" }, new string[] { "Juan" }, new string[] { "Panchito", "Pica piedra" } };
        Imprimir(nombres);

    }

    public void Imprimir(string[][] names){
        
        Console.WriteLine("—— Nombres ——");
        for (int n = 0; n < names.GetLength(0); n++) 
        {
            for (int m = 0; m < names[n].GetLength(0); m++)
            {
                Console.WriteLine(names[n][m]);
            }

        }
    }
    

}