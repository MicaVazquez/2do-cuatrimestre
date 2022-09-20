using System;
using MiBiblioteca;

namespace Ejercicio_3_I01
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("Pepe", 200);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Ingresar(4000);
            Console.WriteLine(cuenta.Mostrar());
            cuenta.Retirar(4020);
            Console.WriteLine(cuenta.Mostrar());


        }
    }
}
