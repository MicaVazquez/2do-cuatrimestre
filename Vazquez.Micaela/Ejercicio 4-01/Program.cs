using System;
using MiBiblioteca;

namespace Ejercicio_4_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //PARTE 1
            /*Cosa obj1 = new Cosa();

            obj1.EstablecerValor(2);
            obj1.EstablecerValor("Hi!");
            obj1.EstablecerValor(new DateTime(2001, 10, 3));

            Console.WriteLine(Cosa.Mostrar(obj1));*/

            //PARTE 2
            DateTime fecha = new DateTime(2019,12,13);
            Cosa obj1 = new Cosa();
            Cosa obj2 = new Cosa("Hola Don Pepito!");
            Cosa obj3 = new Cosa(3,"Hola Don Jose!");
            Cosa obj4 = new Cosa(fecha, 24, "Paso usted por casa?");


            Console.WriteLine(Cosa.Mostrar(obj1));
            Console.WriteLine(Cosa.Mostrar(obj2));
            Console.WriteLine(Cosa.Mostrar(obj3));
            Console.WriteLine(Cosa.Mostrar(obj4));
        }
    }
}
