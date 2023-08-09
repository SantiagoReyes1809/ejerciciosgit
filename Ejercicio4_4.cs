namespace Ejemplo4_4
{
    public class Program
    {
        public static void Main()
        {
            int edad;
            int suma = 0;
            int contador = 0;
            int promedio = 0;
            int cantidad;

            Console.WriteLine("Inserte la cantidad de estudiantes");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (contador < cantidad)
            {

                Console.WriteLine("Inserte una edad");
                edad = Convert.ToInt32(Console.ReadLine());

                suma = suma + edad;
                contador++;
                promedio = suma / contador;

            }
            Console.WriteLine("El promedio de edades es: " + promedio);
        }
    }
}