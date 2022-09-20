using System;

namespace Ejercicio_2_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            string msj;
            Sello.mensaje = "hola mundo";
            msj = Sello.Imprimir();
            Console.WriteLine(msj);
            Sello.Borrar();
            Console.WriteLine(Sello.Imprimir());

            // 2
            Sello.mensaje = "hola mundo C#";
            Sello.color = ConsoleColor.Red;
            Sello.ImprimirEnColor();
            msj = Sello.Imprimir();
            Console.WriteLine(msj);

            
        }
    }
}
