namespace ejemplo3_7
{
    class Program
    {
        public static void Main()
        {
            double precio_Base;
            int tamaño;
            double precio_Inicial;


            Console.WriteLine("Ingrese el precio base por kilo de uva: ");
            precio_Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo (A o B): ");
            var tipo = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingrese el tamaño (1 o 2): ");
            tamaño = Convert.ToInt32(Console.ReadLine());



            if (tipo == "a" && tamaño == 1 || tipo == "A" && tamaño == 1)
            {
                precio_Inicial = (precio_Base + 0.20);
                Console.WriteLine(" el precio inicial por kilo de uva es de " + precio_Inicial);

            }
            else if (tipo == "a" && tamaño == 2 || tipo == "A" && tamaño == 2)
            {
                precio_Inicial = (precio_Base + 0.30);
                Console.WriteLine(" el precio inicial por kilo de uva es de " + precio_Inicial);
            }


            if (tipo == "b" && tamaño == 1 || tipo == "B" && tamaño == 1)
            {
                precio_Inicial = (precio_Base - 0.30);
                Console.WriteLine(" el precio inicial por kilo de uva es de " + precio_Inicial);
            }
            else if (tipo == "b" && tamaño == 2 || tipo == "B" && tamaño == 2)
            {
                precio_Inicial = (precio_Base - 0.50);
                Console.WriteLine(" el precio inicial por kilo de uva es de " + precio_Inicial);
            }

        }
    }
}    