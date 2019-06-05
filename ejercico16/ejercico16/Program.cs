using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico16
{
    class Program
    {
        static float numero;
        static string ingreso;
        static void Main(string[] args)
        {
            numero = 0;
            ingreso = "";
            NegativooPositivo();
            Console.ReadKey();
        }
        static private void NegativooPositivo()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso= Console.ReadLine();
            numero = Convert.ToSingle(ingreso);
            if (numero > 0)
            {
                Console.WriteLine("Su numero es positivo");
            }
            else
            {
                Console.WriteLine("Su numero es negativo");
            }
        }
    }
}
