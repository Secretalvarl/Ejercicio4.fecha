using System;

namespace Ejercicio4.fecha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu fecha de nacimiento (dd-MM-yyyy): ");

            if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
            {
                TimeSpan fechaActual = DateTime.Now - fechaNacimiento;
                DateTime edadCalcular = DateTime.MinValue + fechaActual;

                int años = edadCalcular.Year - 1;
                int meses = edadCalcular.Month - 1;
                int dias = edadCalcular.Day - 1;

                Console.WriteLine("Edad: " + años + " " + "años, " +  meses + " " + "meses, " + dias +" " + "días");
            }
        }
    }
}