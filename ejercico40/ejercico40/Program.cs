using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico40
{
    class Program
    {
        static int numero, contador;
        static string ingreso;
        static void Main(string[] args)
        {
            numero = 0;
            contador = 0;
            ingreso = "";

            NumeroPrimo();
            Console.ReadKey();
        }
        static private void NumeroPrimo()
        {

            Console.WriteLine("Ingrese un numero");
            ingreso = Console.ReadLine();
            numero = Convert.ToInt32(ingreso);

           
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                    { 
                    contador = contador + 1;
                }
            }

            
            if (contador == 2)  
            {
                Console.WriteLine(numero + " es un numero primo y su menor número primo es 2"); 
            }
            else
            {
                Console.WriteLine(numero + " no es un numero primo y su menor número primo es 2");
            }
        }
    }
}
