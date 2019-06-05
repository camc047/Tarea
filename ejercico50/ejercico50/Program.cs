using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercico50
{
    class Program
    {
        static float radio, p;
        static string ingreso;
        static void Main(string[] args)
        {
            radio = 0;
            p = 3.1416f;
            ingreso = "";

            Console.WriteLine("Ingrese el radio de la circunferencia: ");
            ingreso = Console.ReadLine();
            radio = Convert.ToSingle(ingreso);

            Console.WriteLine("El diámetro es de: " + (radio / p));
            
            Console.WriteLine("El área es de: " + (p * (radio * radio)));

            Console.WriteLine("El área es de: " + (p * (radio * radio)));

            Console.ReadKey();
        }        
    }
}
