namespace Ejemplo4_6
{
    public class program
    {
        public static void Main()
        {
            int mes = 0;
            int ahorro = 0;
            int total = 0;
            while (mes < 12)
            {
                mes++;
                Console.WriteLine("Ingrese el ahorro del mes: " + mes);
                ahorro = Convert.ToInt32(Console.ReadLine());
                total = total + ahorro;
                Console.WriteLine("El ahorro hasta el mes " + mes + " es: " + total);
                Console.WriteLine("");
            }
        }
    }
}