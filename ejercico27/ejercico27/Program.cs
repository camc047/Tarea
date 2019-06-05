using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico27
{
    class Program
    {
        static int i, conteo;
        static string ingreso;
        static float numero;
        static void Main(string[] args)
        {
            i = 1;
            conteo = 0;
            ingreso = "";
            numero = 0;

            MultiploConteo();
            Console.ReadKey();

        }
        static private void MultiploConteo()
        {
            Console.WriteLine("Ingrese para determinar el final del ciclo");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

            while (i<=numero)
            {
                if ((i % 2 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine(i);
                    conteo = conteo + 1;
                }
                i = i + 1;
            }
            Console.WriteLine("Hay un total de " + conteo + "Multiplos de 2 y 3");
        }
    }
}
