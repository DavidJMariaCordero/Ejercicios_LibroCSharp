using System;
using System.Collections;

public class Exercise5_7
{
    ArrayList Agenda = new ArrayList();
    public Exercise5_7()
    {
        Inicializar();
    }
    void Inicializar()
    {
        Menu();
    }

    public void Imprimir()
    {
        Console.Clear();
        Console.WriteLine("<--AGENDA-->");
        foreach (Contacto contact in Agenda)
            Console.WriteLine($"\nNombre: {contact.Nombre} Telefono: {contact.Telefono}");
        Menu();
    }

    public void Agregar()
    {
        Console.WriteLine("\nIngrese el nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("\nIngrese el Telefono: ");
        string telefono = Console.ReadLine();
        Agenda.Add(new Contacto(nombre, telefono));
        Menu();

    }

    public void Menu()
    {
        Console.WriteLine("\nPulse la tecla [X] para agregar un contacto");
        Console.WriteLine("Pulse la tecla [Z] para visualizar la agenda");
        Console.WriteLine("Pulse cualquier otra letra para volver al menu anterior");
        Console.WriteLine("Pulse su opcion: ");

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.X:
                Agregar();
                break;
            case ConsoleKey.Z:
                Imprimir();
                break;
            default:
                Console.WriteLine("Bye Bye!!");
                break;
        }
    }

}

public class Contacto
{
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public Contacto(string nombre, string telefono)
    {
        this.Nombre = nombre;
        this.Telefono = telefono;
    }
}
