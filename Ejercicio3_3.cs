using System;
namespace ejemplo3_3
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite la cantidad de lapices a comprar");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num >= 1000)
            {
                double valorTotal = (num * 85) / 100;
                Console.WriteLine("El valor total de la compra de los lapices es de: " + valorTotal);
            }
            else if (num < 1000)
            {
                double valorTotal = (num * 90) / 100;
                Console.WriteLine("El valor total de la compra de los lapices es de: " + valorTotal);
            }
        }
    }
}