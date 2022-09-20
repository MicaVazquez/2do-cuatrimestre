using System;
using ClassLibrary2;

namespace Clase4_Ejer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta(ConsoleColor.DarkMagenta, ETipoTinta.ConBrillito);
            Tinta tinta2 = new Tinta(ConsoleColor.DarkMagenta, ETipoTinta.ConBrillito);
            Tinta tinta3 = new Tinta();


            Pluma pluma1 = new Pluma("pirulo", tinta1, 24);
            


            if(tinta1 == tinta2)
            {
                Console.WriteLine("Son iguales en tipo y color!");
            }
            else
            {
                Console.WriteLine("No son iguales en tipo y color!");
            }
            

            Console.WriteLine((string)tinta2);
            Console.WriteLine(pluma1);

           


            Console.ResetColor();
        }
    }
}
