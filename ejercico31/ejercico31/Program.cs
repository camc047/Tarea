using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico31
{
    class Program
    {
        static int i, serie;
        static void Main(string[] args)
        {
            i = 0;
            serie = 0;

            while (i <= 10)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
            serie = serie + 1;
            Console.ReadKey();
        }
        
    }
}
