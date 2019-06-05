using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico15
{
    class Program
    {
        static int potencia;
        static string ingreso;
        static float i, suma, numero;
        static double dato;
        static void Main(string[] args)
        {
            i = 0;
            ingreso = "";
            numero = 0;

            NumeroMenorI();
            cuadrados();
            Console.ReadKey();
        }
        static private void NumeroMenorI()
        {
            Console.WriteLine("Ingrese un numero menor a 100");
            ingreso = Console.ReadLine();
            numero = Convert.ToSingle(ingreso);

        }

        static private void cuadrados()
        {
            i = numero;
            while (i<=100)
            {
                dato = Math.Pow(i, 2);
                potencia = Convert.ToInt32(ingreso);
                Console.WriteLine(i);
                suma = suma + potencia;
                i = i + 4;
            }
            Console.WriteLine("La suma de los cuadrados que estan separados entres sí, cuatro posiciones es de:" + suma);
        }

    }
}
