using System;
using System.ComponentModel.Design;

class ventas
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al programa de tienda");
        Console.WriteLine("Favor ingrese su nombre");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese edad");
        int Edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Seleccione la categoria del producto a comprar");
        Console.WriteLine("1. Lacteos");
        Console.WriteLine("2. Embutidos");
        Console.WriteLine("3. Refrescos");
        Console.WriteLine("4. Cereales");
        Console.WriteLine("5. Productos de Limpieza");
        string categoria = Console.ReadLine();
        double precio;
        string producto;

        if (categoria == "1")
        {

            Console.WriteLine("Tenemos los siguientes productos,escriba el numero que desea");
            Console.WriteLine("1. Queso 80 lps la libra");
            Console.WriteLine("2. Cuajada 80 lps la libra");
            Console.WriteLine("3. Mantequilla 40 lps la libra");
            producto = Console.ReadLine();

            if (producto == "1")
            {
                precio = 80;
            }
            else if (producto == "2")
            {
                precio = 40;
            }
            else if (producto == "3")
            {
                precio = 65;
            }
            else if (producto == "4")
            {
                precio = 85;
            }
            else if (producto == "5")
            {
                precio = 45;
            }
            else
            {
                Console.WriteLine("No tenemos el producto seleccionado");
            }

        }
        else if (categoria == "2")
        {
            Console.WriteLine("Tenemos los siguientes productos,escriba el numero deseado");
            Console.WriteLine("1. Copetines 40 lps la libra");
            Console.WriteLine("2. Chorizo Zambrano 40 lps la libra");
            Console.WriteLine("3. Jamon 28 lps la libra");
        }
        else if (categoria == "3")
        {
            Console.WriteLine("Tenemos los siguientes productos,escriba el numero deseado");
            Console.WriteLine("1. Banana 65 lps tres litros");
            Console.WriteLine("2. Coca Cola 65 lps tres litros");
            Console.WriteLine("3. Fresca 65 lps tres litros");
        }
        else if (categoria == "4")
        {
            Console.WriteLine("Tenemos los siguientes productos,escriba el numero deseado");
            Console.WriteLine("1. Corn Flakes 85 caja grande");
            Console.WriteLine("2. Choco Qurispi 85 lps caja grande");
            Console.WriteLine("3. Zucarita 85 lps caja grande");
        }
        else if (categoria == "5")
        {
            Console.WriteLine("Tenemos los siguientes productos,escriba el numero deseado");
            Console.WriteLine("1. Cloro 45 lps bote grande");
            Console.WriteLine("2. Suavitel 45 lps bote grande");
            Console.WriteLine("3. Asistin 45 lps bote grande");
        }
        else
        {

            Console.WriteLine("El numero de producto seleccionado no existe");
        }
        Console.WriteLine("El precio del producto es = + precio");
    }
}