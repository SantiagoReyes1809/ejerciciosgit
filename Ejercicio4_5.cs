namespace Ejemplo4_5
{
    public class Program
    {
        public static void Main()
        {
            int c = 0;
            int estatura = 1;
            int suma = 0;
            int promedio = 0;

            while (estatura > 0)
            {
                Console.WriteLine("Ingrese una estatura: ");
                estatura = Convert.ToInt32(Console.ReadLine());
                c = c + 1;
                suma = suma + estatura;
            }
            promedio = suma / (c - 1);
            Console.WriteLine("El promedio de estaturas es : " + promedio);
        }
    }
}