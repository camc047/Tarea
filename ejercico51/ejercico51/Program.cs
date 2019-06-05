using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico51
{
    class Program
    {
        static int num1, num2;
        static string ingreso;
        static void Main(string[] args)
        {
            num1 = 0;
            num2 = 0;
            ingreso = "";

            Console.WriteLine("Ingrese el primer número: ");
            ingreso = Console.ReadLine();
            num1 = Convert.ToInt32(ingreso);

            Console.WriteLine("Ingrese el segundo número: ");
            ingreso = Console.ReadLine();
            num2 = Convert.ToInt32(ingreso);

            multiploDelPrimero();
            Console.ReadKey();
        }

        static private void multiploDelPrimero()
        {

            if (num1 % num2 == 0)
            {
                Console.WriteLine(num1 + " es múltiplo de " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " no es múltiplo de " + num2);
            }
        }
    }
}
