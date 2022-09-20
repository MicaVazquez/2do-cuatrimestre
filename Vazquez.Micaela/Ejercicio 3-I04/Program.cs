using System;
using MiBiblioteca;

namespace Ejercicio_3_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            bool ok;
           // Boligrafo b1 = new Boligrafo(100, ConsoleColor.Blue);
            //b1.Recargar();
            //Console.WriteLine($"{b1.GetTinta()} {b1.GetColor()}");

            Boligrafo b2 = new Boligrafo(50, ConsoleColor.Red);

            ok = b2.Pintar(70, out dibujo);

            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine($" Ok : {ok} \n Dibujo : {dibujo}");
            Console.ResetColor();
            Console.WriteLine($"{b2.GetTinta()}");
        }
    }
}
