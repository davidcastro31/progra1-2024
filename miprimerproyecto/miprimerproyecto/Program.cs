using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miprimerproyecto
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Num1: ");
            sbyte num1 = sbyte.Parse(Console.ReadLine());

            Console.Write("Num 2: ");
            sbyte num2 = sbyte.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.WriteLine("La suma de {0} + {1} = {2}", num1, num2, respuesta);
            int suma = num1 + num2;

            //Pausa.
            Console.ReadLine();
        }
    }
}
