using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico35
{
    class Program
    {
        static int cociente, resto;
        static float dividendo, divisor;
        static string ingreso;
        static void Main(string[] args)
        {
            cociente = 0;
            resto = 0;
            dividendo = 0;
            divisor = 0;
            ingreso = "";

            Restas();
            Console.ReadKey();
        }
        static private void Restas()
        {
            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            dividendo = Convert.ToSingle(ingreso);

            Console.WriteLine("Ingrese el segundo numero");
            ingreso = Console.ReadLine();
            divisor = Convert.ToSingle(ingreso);

            if ((dividendo >= 0) && (divisor >= 0)) 
            {
                resto = Convert.ToInt32(dividendo);  
                while (resto >= divisor)
                {
                    resto = resto - Convert.ToInt32(divisor);  
                    cociente = cociente + 1;  

                }

                Console.WriteLine("El cociente es de: " + cociente);  
                Console.WriteLine("El resto es de: " + resto); 
            }
            else
            {
                Console.WriteLine("Eror, Usted ha escrito un número negativo");
            }
        }
    }
}
