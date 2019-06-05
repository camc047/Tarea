using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico4
{
    class NumerosPares
    {
        static int i;
        static void Main(string[] args)
        {
            i = 0;
            NumerosPares0a100();
            Console.ReadKey();
       }
        static private void NumerosPares0a100()
        {
            while (i<=100)
            {
                Console.WriteLine(i);
                i = i + 2;
            }
        }
    }
}
