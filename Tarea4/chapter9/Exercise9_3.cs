/*Crear estructuras enlazadas para guardar
la información de una mascota y su
dueño.*/
using System;
using System.Text;

public class Exercise9_3
{

    public Exercise9_3()
    {
        Inicializar();
    }

    public struct Dueño
    {
        string nombre;
        string telefono;
        string direccion;
        Mascota mascota;

        public Dueño(string nombre, string telefono, string direccion, Mascota mascota)
        {
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;

            this.mascota = mascota;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Dueño\nNombre: { nombre}\t Telefono: {telefono}\tDireccion: {direccion}\nMascota\n{mascota.ToString()} ");
            return (sb.ToString());
        }
    }

    public struct Mascota
    {
        string nombre;
        string raza;
        string tipo;

        public Mascota(string nombre, string raza, string tipo)
        {
            this.nombre = nombre;
            this.raza = raza;
            this.tipo = tipo;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: { nombre}\t Tipo: {tipo}\tRaza: {raza} ");
            return (sb.ToString());
        }
    }

    public void Inicializar()
    {
        string nombre;
        string telefono;
        string direccion;

        string nombreMascota;
        string tipo;
        string raza;

        Dueño dueño;
        Mascota mascota;

        Console.WriteLine("Digite el nombre del dueño: ");
        nombre = Console.ReadLine();

        Console.WriteLine("Digite el numero de telefono: ");
        telefono = Console.ReadLine();

        Console.WriteLine("Digite la direccion: ");
        direccion = Console.ReadLine();

        Console.WriteLine("Digite el nombre de la mascota: ");
        nombreMascota = Console.ReadLine();

        Console.WriteLine("Digite el tipo de mascota: ");
        tipo = Console.ReadLine();

        Console.WriteLine("Digite la raza: ");
        raza = Console.ReadLine();

        mascota = new Mascota(nombre, raza, tipo);
        dueño = new Dueño(nombre, telefono, direccion, mascota);

        Console.WriteLine(dueño.ToString());

    }


}