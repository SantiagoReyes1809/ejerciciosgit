namespace Ejemplos
{
    public class ejercicio2_7
    {
        public static void Main()
        {
            Console.WriteLine("Inserte la cantidad de litros: ");
            double litros_vendidos = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Inserte el valor por galon: ");
            double valorGalon = (Convert.ToInt32(Console.ReadLine()));

            double galones_vendidos = Math.Truncate(litros_vendidos / 3.785);
            double pagoGalon = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("La cantidad de leche en galones es:  " + galones_vendidos);
            Console.WriteLine("La cantidad de galones de leche vendida es:  " + (galones_vendidos * pagoGalon));
        }


    }
}