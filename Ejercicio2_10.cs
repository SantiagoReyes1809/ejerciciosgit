namespace Ejemplos
{
    public class ejercicio2_10
    {
        public static void Main()
        {
            Console.WriteLine("Inserte una cantidad de metros necesitados: ");
            double met_Neces = (Convert.ToInt32(Console.ReadLine()));

            double pulg_Neces = Math.Truncate(met_Neces / 0.0254);
            Console.WriteLine("La cantidad de pulgadas necesitadas son: " + pulg_Neces);
        }


    }
}