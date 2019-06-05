using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico33
{
    class Program
    {
        static float numero, factor;
        static int i;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 1;
            numero = 0;
            ingreso = "";
            factor = 1;

            Factorial();
            Console.ReadKey();
        }
        static private void Factorial()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

            while(i<=numero)
            {
                factor = factor * i;
                i = i + 1;

            }
            if (numero>=0)
            {
                Console.WriteLine("El factorial es de" + factor);
            }
            else
            {
                Console.WriteLine("Es un numero negativo, este no tiene factorial");
            }
        }
    }
}
