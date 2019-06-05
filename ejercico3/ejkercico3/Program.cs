using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico3
{
    class ciennumeros
    {
        static int i, suma;
        static void Main(string[] args)
        {
            i = 1;
            suma = 0;

            SumasDeNumeros();
            Console.ReadKey();
        }
        
        static private void SumasDeNumeros()
        {
            while (i<=100)
            {
                suma = suma + i;
                i = i + 1;
                Console.WriteLine(suma);
                
            }
            
        }
    }
}
