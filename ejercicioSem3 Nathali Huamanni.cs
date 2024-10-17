using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioSem3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingresar cargo del trabajador (Gerente, Administrador, Supervisor u Obrero): ");
            string cargo = Console.ReadLine().ToLower(); 

            Console.WriteLine("Ingrese las horas trabajadas a la semana:");
            int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

            double pagoRegular = 0;
            double horasExtras = 0;
            double pagoHorasExtras = 0;
            double pagoTotal = 0;

            switch (cargo)
            {
                case "gerente":
                    if (horasTrabajadas <= 40)
                    {
                        pagoRegular = horasTrabajadas * 120;
                    }
                    else
                    {
                        pagoRegular = 40 * 120;
                        horasExtras = horasTrabajadas - 40;
                        pagoHorasExtras = horasExtras * 120 * 0.5;
                    }
                    break;
                case "administrador":
                    if (horasTrabajadas <= 40)
                    {
                        pagoRegular = horasTrabajadas * 80;
                    }
                    else
                    {
                        pagoRegular = 40 * 80;
                        horasExtras = horasTrabajadas - 40;
                        pagoHorasExtras = horasExtras * 80 * 0.25;
                    }
                    break;
                case "supervisor":
                    if (horasTrabajadas <= 48)
                    {
                        pagoRegular = horasTrabajadas * 50;
                    }
                    else
                    {
                        pagoRegular = 48 * 50;
                        horasExtras = horasTrabajadas - 48;
                        pagoHorasExtras = horasExtras * 50 * 0.25;
                    }
                    break;
                case "obrero":
                    if (horasTrabajadas <= 48)
                    {
                        pagoRegular = horasTrabajadas * 30;
                    }
                    else
                    {
                        pagoRegular = 48 * 30;
                        horasExtras = horasTrabajadas - 48;
                        pagoHorasExtras = horasExtras * 30 * 0.2;
                    }
                    break;
                default:
                    Console.WriteLine("Cargo inválido.");
                    return;
            }

            pagoTotal = pagoRegular + pagoHorasExtras;

            Console.WriteLine("Cantidad de horas extras: " + horasExtras);
            Console.WriteLine("Monto del pago regular: " + pagoRegular);
            Console.WriteLine("Monto del pago por horas extras: " + pagoHorasExtras);
            Console.WriteLine("Monto total: " + pagoTotal);

            Console.ReadKey();

        }
    }
}
