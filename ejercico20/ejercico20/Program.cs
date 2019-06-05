using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico20
{
    class Program
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            Multiplo();
            Console.ReadKey();
        }
        static private void Multiplo()
            {
            while(i<=100)
            {
                if ((i % 2 == 0) || (i % 3 == 0))
                {
                    Console.WriteLine(i);
                    conteo = conteo + 1;
                }
                i = i + 1;
            }
            Console.WriteLine("Hay un total de:" + conteo);
        }
    }
}
