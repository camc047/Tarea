using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico37
{
    class Program
    {
        static int entero, contador;
        static string ingreso;
        static double truncado;
        static void Main(string[] args)
        {
            entero = 0;
            contador = 0;
            ingreso = "";
            truncado = 0;

            PositivoNegativo();
            Digitos();
            Console.ReadKey();
        }
        static private void PositivoNegativo()
        {
            Console.WriteLine("Ingrese un número entero positivo: ");
            ingreso = Console.ReadLine();
            entero = Convert.ToInt32(ingreso);

            while (entero < 0)
            {
                Console.WriteLine("Error, Usted ingresó un número negativo, ingrese un número positivo: ");
                ingreso = Console.ReadLine();
                entero = Convert.ToInt32(ingreso);
            }
        }

        static private void Digitos()
        {
            truncado = Convert.ToSingle(entero);

            while (truncado != 0)
            {
                truncado = (Math.Truncate(truncado) / 10);
                contador = contador + 1;
            }

            Console.WriteLine("El número ingresado tiene " + contador + " cifras");
        }
    }
}
