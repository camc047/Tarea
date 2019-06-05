using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico8
{
    class Program
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            i = 3;
            conteo = 0;
            Multiplosde3de1a100();
            Console.ReadKey();
        }
        static private void Multiplosde3de1a100()
        {
            while (i<=100)
            {
                Console.WriteLine(i);
                i = i + 3;
                conteo = conteo + 1;
            }
            Console.WriteLine("Hay un total de" + conteo + "multiplos de 3");
        }
    }
}
