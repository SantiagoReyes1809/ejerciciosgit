namespace Ejemplos
{
    public class ejercicio2_5
    {
        public static void Main()
        {
            Console.WriteLine("ingrese la variable A: ");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la variable B: ");
            double b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese la variable C: ");
            double c = Convert.ToInt32(Console.ReadLine());

            double area_Rectangulo = b * c;
            double area_Triangulo = ((a - c) * b) / 2;
            double area_total = area_Rectangulo + area_Triangulo;
            Console.WriteLine("");
            Console.WriteLine("El resultado es: " + area_total);


        }
    }
}