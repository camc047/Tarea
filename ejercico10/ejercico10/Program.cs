using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico10
{
    class Program
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 5;
            conteo = 5;

            Multiplos5();
            Console.ReadKey();
         }
        static private void Multiplos5()
        {
            while (i <= 500)
            {
                Console.WriteLine(i);
                i = i + 5;
                conteo = conteo + 1;

            }
            Console.WriteLine("Hay un total de" + conteo + "multiplos de 5");

        }
    }
}
