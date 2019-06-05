using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico39
{
    class Program
    {
        static int pre, pos, val;
        static float numero;
        static string ingreso;
        static void Main(string[] args)
        {
            val = 0;
            pre = 0;
            pos = 1;
            numero = 0;
            ingreso = "";

            condicionalParaGeerarSerieFibonacci();
            Console.ReadKey();
        }

        static private void condicionalParaGeerarSerieFibonacci()
        {
            
            Console.WriteLine("Ingrese la cantidad de términos que quiere generar: ");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

            
            Console.WriteLine(pre + "  " + pos);

            for (int i = 3; i <= numero; i++)  
            {
                val = pre + pos;  
                pre = pos;  
                pos = val;  

                Console.WriteLine(val);  
            }
        }
    }
}
