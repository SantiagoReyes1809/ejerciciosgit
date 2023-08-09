namespace ejemplo3_6
{
    class Program
    {
        public static void Main()
        {
            int personas;

            Console.WriteLine("ingrese la cantidad de comensales");
            personas = Convert.ToInt32(Console.ReadLine());

            if (personas < 200)
            {
                Console.WriteLine("El valor del banquete para " + personas + " personas será de " + personas * 95000);

            }

            if (personas >= 200 && personas <= 300)
            {
                Console.WriteLine("El valor del banquete para " + personas + " personas será de " + personas * 85000);

            }

            if (personas > 300)
            {
                Console.WriteLine("El valor del banquete para " + personas + " personas será de " + personas * 75000);

            }
        }
    }
}