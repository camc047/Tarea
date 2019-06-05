using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico38
{
    class Program
    {
        static float inicial, final, diferencia;
        static string ingresado;
        static void Main(string[] args)
        {
            inicial = 0;
            final = 0;
            diferencia = 0;
            ingresado = "";

          
            Console.WriteLine("Ingrese el numero con que se va a iniciar: ");
            ingresado = Console.ReadLine();
            inicial = Convert.ToSingle(ingresado);

            Console.WriteLine("Ingrese el número con que se va a finalizar: ");
            ingresado = Console.ReadLine();
            final = Convert.ToSingle(ingresado);

            Console.WriteLine("Ingrese la diferencia: ");
            ingresado = Console.ReadLine();
            diferencia = Convert.ToSingle(ingresado);

          
            ProgresionAritmetica();
            Identificador();
            Console.ReadKey();
        }

        static private void Identificador()
        {
           
            while ((inicial < 0) || (final < 0))
            {
                Console.WriteLine("Ingrese nuevamente el número con que va a iniciar");
                ingresado = Console.ReadLine();
                inicial = Convert.ToSingle(ingresado);

                Console.WriteLine("Ingrese nuevamente el número con que va a finalizar ");
                ingresado = Console.ReadLine();
                final = Convert.ToSingle(ingresado);
            }

           
            while (diferencia < 0)
            {
                Console.WriteLine("Ingrese la diferencia: ");
                ingresado = Console.ReadLine();
                diferencia = Convert.ToSingle(ingresado);

            }
        }

        static private void ProgresionAritmetica()
        {
            
            while (inicial <= final) 
            {
                Console.WriteLine(inicial);  

                inicial = inicial + diferencia; 
            }
        }
    }
}
