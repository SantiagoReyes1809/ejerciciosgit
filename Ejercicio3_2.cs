using System;
namespace ejemplo3_2
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite un numero");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else if (num < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
        }
    }
}