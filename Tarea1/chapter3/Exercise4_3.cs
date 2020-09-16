using System;
public class Exercise4_3
{
    public Exercise4_3()
    {
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1:
                Console.WriteLine("El día es lunes");
                break;
            case 2:
                Console.WriteLine("El día es martes");
                break;
            case 3:
                Console.WriteLine("El día es miercoles");
                break;
            case 4:
                Console.WriteLine("El día es jueves");
                break;
            case 5:
                Console.WriteLine("El día es viernes");
                break;
            case 6:
                Console.WriteLine("El día es sabado");
                break;
            case 7:
                Console.WriteLine("El día es domingo");
                break;

            default:
                Console.WriteLine("A ingresado un numero incorrecto");
                break;
        }

    }
}
