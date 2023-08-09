

public class Ejemplo3_4
{

    public static void Main()
    {
        double precio_Articulo;
        double precio_Total;

        Console.WriteLine("Ingrese el precio del articulo: ");
        precio_Articulo = Convert.ToDouble(Console.ReadLine());

        if (precio_Articulo <= 2500)
        {
            precio_Total = precio_Articulo - (precio_Articulo * 0.08);
            Console.WriteLine("El precio total es de: " + precio_Total);
        }
        else if (precio_Articulo > 2500)
        {
            precio_Total = precio_Articulo - (precio_Articulo * 0.15);
            Console.WriteLine("El precio total es de: " + precio_Total);

        }
    }
}