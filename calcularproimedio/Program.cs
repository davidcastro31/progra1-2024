using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcularproimedio
{
    class Program
    {
        static void Main(string[] args) {
            //ejercicio de suma de dos numeros introducidos por el usuario
            int[] serie = new int[] { 5, 4, 6, 8, 9 };
            int suma = 0;
            foreach (int num in serie)
            {
                suma = suma + num;
            }
            Console.WriteLine("La suma es: {0}, el promedio es: {1}", suma, suma / serie.Length);
            //pausa
            Console.ReadLine();
        }
    }
}
