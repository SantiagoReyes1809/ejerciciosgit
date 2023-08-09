namespace ejemplo4_1
{
    class Program
    {
        public static void Main()
        {
            int contador = 0;
            int num1;
            int sum = 0;
            ;
            while (contador < 10)
            {
                contador++;
                Console.WriteLine("Ingrese el numero:");
                num1 = Convert.ToInt32(Console.ReadLine());
                sum = sum + num1;
                ;
            }
            Console.WriteLine("La suma de los 10 numeros es " + sum);
        }
    }
}