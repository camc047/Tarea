using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico21
{
    class Program
    {
        static int i, conteo;
        static void Main(string[] args)
        {
            Multiplos();
            Console.ReadKey();
        }
        static private void Multiplos()
        {
            while(i<=100)
            {
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine(i);
                    conteo = conteo + 1;
                }
                i = i + 1;
            }
            Console.WriteLine("El conteo total de los multiplos de los 2 y 3 es de:" + conteo);
        }
    }
}
