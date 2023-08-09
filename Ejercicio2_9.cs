namespace Ejemplos
{
    public class ejercicio2_9
    {
        public static void Main()
        {
            Console.WriteLine("Inserte la cantidad de horas trabajadas");
            double horas_Trabajadas = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Inserte su pago por hora");
            double pago_Hora = (Convert.ToInt32(Console.ReadLine()));

            double salario_semanal = horas_Trabajadas * pago_Hora;

            Console.WriteLine("Su salario semanal trabajando " + horas_Trabajadas + " horas a la semana,con un pago por hora de " + pago_Hora + " es " + salario_semanal);
        }


    }
