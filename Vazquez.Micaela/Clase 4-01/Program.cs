using System;
using MiBiblioteca;

namespace Clase_4_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Cosa cosa1 = new Cosa();
            cosa1.EstablecerValor(1);
            cosa1.EstablecerValor("hola");
            cosa1.EstablecerValor(new DateTime(2001, 10, 13));

            Console.WriteLine(Cosa.Mostrar(cosa1));
        }
    }
}
