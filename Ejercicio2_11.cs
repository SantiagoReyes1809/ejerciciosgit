namespace Ejemplos
{
    public class ejercicio2_11
    {
        public static void Main()
        {
            Console.WriteLine("Inserte el largo de la piscina: ");
            double lado_Largo = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Inserte el ancho de la piscina: ");
            double lado_Ancho = (Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Inserte el fondo de la piscina: ");
            double lado_Fondo = (Convert.ToDouble(Console.ReadLine()));

            double metros_cuadrados = lado_Ancho * lado_Fondo * lado_Largo;

            Console.WriteLine("Inserte el pago por metro cuadrado");
            double pago_metro2 = (Convert.ToDouble(Console.ReadLine()));

            double pago_piscina = metros_cuadrados * pago_metro2;

            Console.WriteLine(pago_piscina);
        }


    }
}
