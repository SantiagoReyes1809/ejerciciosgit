namespace ejercicio3_5
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Digite el primer valor: ");
            int num1;
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el segundo valor: ");
            int num2;
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite el tercer valor: ");
            int num3;
            num3 = Convert.ToInt16(Console.ReadLine());

            if (num1 > num2 & num1 > num3)
            {
                Console.WriteLine("El valor mayor es: " + num1);
            }
            else if (num2 > num1 & num2 > num3)
            {
                Console.WriteLine("El valor mayor es: " + num2);

            }
            if (num3 > num1 & num3 > num2)
            {
                Console.WriteLine("El valor mayor es: " + num3);
            }
            else if (num1 == num2 & num1 == num3)
            {
                Console.WriteLine("Todos son iguales");
            }
        }
    }

}