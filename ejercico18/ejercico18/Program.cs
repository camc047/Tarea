using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico18
{
    class Program
    {
        static float numero;
        static int conteo, i;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 3;
            conteo = 0;
            ingreso = "";
            numero = 0;
            Multiplos();
            Console.ReadKey();
        }
        static private void Multiplos()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

            while(i <= numero)
            {
                Console.WriteLine(i);
                i = i + 3;
                conteo = conteo + 1;
            }
            Console.WriteLine("Hay untotal de:" + conteo + "multiplos de 2");
        }
    }
}
