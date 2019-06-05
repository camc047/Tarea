using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico28
{
    class Program
    {
        static int i, conteo;
        static float multiplos, determinado, mayor, numero;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 1;
            multiplos = 0;
            determinado = 0;
            mayor = 0;
            ingreso= "";
            numero = 0;
            conteo = 0;

            Multiplos5();
            Console.ReadKey();
        }
        static  private void Multiplos5()
        {
            Console.WriteLine("Ingrese un numero para determinar el fin");
            ingreso = Console.ReadLine();
            determinado = Convert.ToSingle(ingreso);

            while(i<=determinado)
            {
                Console.WriteLine("Ingrese un numero");
                ingreso = Console.ReadLine();

                numero = Convert.ToSingle(ingreso);

                if (numero % 5 == 0)  
                {
                    multiplos = multiplos + numero;  
                }
                if (numero > mayor)  
                {
                   mayor = numero; 
                }
                i = i + 1;  
                conteo = conteo + 1;
            }
            Console.WriteLine("La suma de los múltiplos de 5 es de: " + multiplos);
            Console.WriteLine("El número mayor es: " + mayor);
            Console.WriteLine("el total de numeros ingresados es de: " + conteo );
        }
    }
}
