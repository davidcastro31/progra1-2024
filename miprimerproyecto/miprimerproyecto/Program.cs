﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miprimerproyecto
{
    class Program
    {
        static void Main(string[] args){
            Boolean comprobar = true;
            Console.WriteLine("el valor es: {0} ",comprobar);
            //Prioridad de los operadores aritmeticos.
            //se pone el sufijo m para la division con decimales.
            decimal respuesta = 5 + 8 - 2 * 5 / 4m + 1;//valor incorrecto: 14.75, valor correcto 11.5.
            Console.WriteLine("La respuesta es: {0} ", respuesta);

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Hola {0} bienvenido ",nombre);

            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;
            Console.WriteLine("La fecha actual es: {0} ", fechaActual);
            Console.WriteLine("La division de 5/4 es {0}", 5 / 4);

            //Pausa.
            Console.ReadLine();
        }
    }
}
