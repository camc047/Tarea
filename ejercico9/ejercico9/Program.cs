using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico9
{
    class Program
    {
        static int i, suma;
        static void Main(string[] args)
        {
            i = 1;
            suma = 0;
            
            SumaImpar();
            Console.ReadKey();
        }
    
        static private void SumaImpar()
        {
            while (i<=100)
            {
                suma = suma + i;
                i = i + 2;
            }
            Console.WriteLine("La suma de los impares es de" + suma);
        }
    }
}
