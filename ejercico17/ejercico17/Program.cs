using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico17
{
    class Program
    {
        static float numero;
        static string ingreso;
        static void Main(string[] args)
        {
            numero = 0;
            ingreso = "";

            ParImpar();
            Console.ReadKey();
        } 
        static private void ParImpar()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

            if(numero % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}
