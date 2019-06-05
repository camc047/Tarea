using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico30
{
    class Program
    {
        static float cantidad, porcentaje1, porcentaje2, porcentaje3, restaporcentaje1, sumaPorcentaje2, sumaPorcentaje3;
        static string ingreso;
        static void Main(string[] args)
        {
            cantidad = 0;
            porcentaje1 = 0;
            porcentaje2 = 0;
            porcentaje3 = 0;
            restaporcentaje1 = 0;
            sumaPorcentaje2 = 0;
            sumaPorcentaje3 = 0;
            ingreso = "";

            Porcentajes();
            Console.ReadKey();
        }
        static private void Porcentajes()
        {
            Console.WriteLine("Ingrese una cantidad");
            ingreso = Console.ReadLine();
            cantidad = Convert.ToSingle(ingreso);

            if (cantidad < 500)
            {
                porcentaje1 = cantidad * 0.5f;
                sumaPorcentaje3 = cantidad + porcentaje1;
                Console.WriteLine("La suma del 50 porciento es de: " + sumaPorcentaje2);
            }
            else
            {
                Console.WriteLine(cantidad + " no es menor que 500");
            }


            if ((cantidad >= 500) && (cantidad < 1000))
            {
                porcentaje2 = cantidad * 0.07f;
                sumaPorcentaje3 = cantidad + porcentaje2;
                Console.WriteLine("La suma del 7 porciento es de: " + sumaPorcentaje3);
            }
            else
            {
                Console.WriteLine("Su cantidad no sea mayor o igual que 500, o no sea menor que 1000 ");
            }
            if ((cantidad > 1000) && (cantidad <= 5000))
            {
                porcentaje3 = cantidad * 0.05f;
                restaporcentaje1 = cantidad - porcentaje3;
                Console.WriteLine("La resta del 5 porciento es de: " + restaporcentaje1);
            }
            else
            {
                Console.WriteLine("La cantidad no sea mayor que 1000, o no sea menor o igual que 5000");
            }
        }
    }
}
