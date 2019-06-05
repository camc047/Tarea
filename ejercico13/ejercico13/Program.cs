using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico13
{
    class Program
    {
        static int conteo;
        static float i, suma, numero;
        static string ingreso;
        static void Main(string[] args)
        {
            i = 0;
            conteo = 0;
            suma = 0;
            numero = 0;
            ingreso = "";

            NumeroIngresado();
            NumeroMenorI();
            Console.ReadLine();
        }
        static private void NumeroIngresado()
        {
            Console.WriteLine("Ingrese un numero menor a 500");
            ingreso = Console.ReadLine();

            numero = Convert.ToSingle(ingreso);
            while(numero > 500)
            {
                Console.WriteLine("Usted ingreso un numero mayor a 500, ingrese un numero menor");

                ingreso = Console.ReadLine();
                numero = Convert.ToSingle(ingreso);
            }
        }
        static private void NumeroMenorI()
        {
            i = numero;
            while (i<=500)
            {
                Console.WriteLine(i);
                suma = suma + i;
                i = i + 8;
                conteo = conteo + 1;
            }
            Console.WriteLine("Hay un total de:" + conteo);
            Console.WriteLine("la suma total es de:" + suma);
        }
    }
}
