/*Crear una estructura para guardar los
productos de una tienda.*/

using System;
using System.Text;

class Exercise9_1
{

    public Exercise9_1(){
        Inicializar();
    }
    public struct Articulos
    {
        public string nombre;
        public int cantidad;
        public double precio;

        public Articulos(String nombre, int cantidad, Double precio)
        {
            this.nombre = nombre;

            this.cantidad = cantidad;
            this.precio = precio;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat($"Nombre: { nombre}\nCantidad: {cantidad}\nPrecio: {precio}");
            return (sb.ToString());
        }

    }

    public void Inicializar()
    {
        string nombre;
        int cantidad;
        double precio;
        Articulos[] articulos;
        int cantidadArticulos;

        Console.WriteLine("Digite la cantidad de productos que desea registrar: ");
        cantidadArticulos = Convert.ToInt32(Console.ReadLine());
        articulos = new Articulos[cantidadArticulos];

        for (int i = 0; i < cantidadArticulos; i++)
        {
            Console.WriteLine("Digite el nombre del producto: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Digite la cantidad del producto: ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el precio del producto: ");
            precio = Convert.ToDouble(Console.ReadLine());

            articulos[i] = new Articulos(nombre, cantidad, precio);
        }

        for (int i = 0; i < cantidadArticulos; i++)
            Console.WriteLine(articulos[i].ToString());

    }

}
