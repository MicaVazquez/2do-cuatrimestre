using System;
using ClassLibrarySobrecarga;

namespace Ejercicio5_I01_Sumador
{
    class Program
    {
        static void Main(string[] args)
        {

            Sumador sumador1 = new Sumador(20);
            Console.WriteLine($"Cantidad sumas: {sumador1.GetCantidadSuma()}");
            string ResultadoString = sumador1.Sumar("Hello", " World");

            Console.WriteLine($"Resultado string {ResultadoString}");
            Console.WriteLine($"Cantidad sumas: {sumador1.GetCantidadSuma()}");

            long ResultadoLong = sumador1.Sumar(15,20);

            Console.WriteLine($"Resultado Long {ResultadoLong}");
            Console.WriteLine($"Cantidad sumas: {sumador1.GetCantidadSuma()}");





        }
    }
}
