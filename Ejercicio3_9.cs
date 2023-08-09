namespace ejemplo3_9
{
    class Program
    {
        public static void Main()
        {
            double minutos;
            double precio_Minuto;
            double precio_Llamada;
            Console.WriteLine("ingrese los minutos que duró la llamada");
            minutos = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("¿La llamada se realizó en un dia habil? (S para marcar si , N para marcar no )");
            var dia = Convert.ToString(Console.ReadLine());

            if (dia == "s" || dia == "S")
            {
                Console.WriteLine("¿La llamada se realizó en turno matutino o vespertino? (M para marcar matutino , V para marcar vespertino )");
                var turno = Convert.ToString(Console.ReadLine());
                if (turno == "m" && minutos <= 5 || turno == "M" && minutos <= 5)
                {
                    precio_Minuto = minutos * 1;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.15);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);
                }

                if (turno == "m" && minutos >= 6 && minutos <= 8 || turno == "M" && minutos >= 6 && minutos <= 8)
                {
                    precio_Minuto = minutos * 0.8;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.15);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (turno == "m" && minutos >= 9 && minutos <= 10 || turno == "M" && minutos >= 9 && minutos <= 10)
                {
                    precio_Minuto = minutos * 0.7;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.15);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (turno == "m" && minutos > 10 || turno == "M" && minutos > 10)
                {
                    precio_Minuto = minutos * 0.5;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.15);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }




                if (turno == "v" && minutos <= 5 || turno == "V" && minutos <= 5)
                {
                    precio_Minuto = minutos * 1;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.10);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (turno == "v" && minutos >= 6 && minutos <= 8 || turno == "V" && minutos >= 6 && minutos <= 8)
                {
                    precio_Minuto = minutos * 0.8;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.10);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (turno == "v" && minutos >= 9 && minutos <= 10 || turno == "V" && minutos >= 9 && minutos <= 10)
                {
                    precio_Minuto = minutos * 0.7;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.10);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (turno == "v" && minutos > 10 || turno == "V" && minutos > 10)
                {
                    precio_Minuto = minutos * 0.5;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.10);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }
            }


            if (dia == "n" || dia == "N")
            {
                if (minutos <= 5)
                {
                    precio_Minuto = minutos * 1;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.03);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (minutos <= 8)
                {
                    precio_Minuto = minutos * 0.8;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.03);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (minutos <= 10)
                {
                    precio_Minuto = minutos * 0.7;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.03);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

                if (minutos > 10)
                {
                    precio_Minuto = minutos * 0.5;
                    precio_Llamada = precio_Minuto + (precio_Minuto * 0.03);
                    Console.WriteLine("el precio de la llamada es: " + precio_Llamada);

                }

            }

        }
    }
}