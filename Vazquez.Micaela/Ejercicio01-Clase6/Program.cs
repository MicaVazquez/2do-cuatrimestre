using System;
using BibliotecaClass7;

namespace Ejercicio01_Clase6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tempera tem1 = new Tempera(ConsoleColor.Red, "Alba", 50);
            Tempera tem2 = new Tempera(ConsoleColor.Blue, "Alba", 50);
            Tempera tem3 = new Tempera(ConsoleColor.Red, "Alba", 25);
            Tempera tem4 = new Tempera(ConsoleColor.Black, "Pinturita", 50);
            Tempera tem5 = new Tempera(ConsoleColor.Green, "Temperita", 50);
            


            #region Comparar
            if (tem1 == tem2)
            {
                Console.WriteLine("1.Si");
            }
            else
            {
                Console.WriteLine("1.no");
            }

            if (tem1 == tem3)
            {
                Console.WriteLine("2.Si");
            }
            else
            {
                Console.WriteLine("2.no");
            }

            if (tem1 == tem4)
            {
                Console.WriteLine("3.Si");
            }
            else
            {
                Console.WriteLine("3.no");
            }


            if (tem1 == null)
            {
                Console.WriteLine("4.Si");
            }
            else
            {
                Console.WriteLine("4.no");
            }


            if (null == tem1)
            {
                Console.WriteLine("5.Si");
            }
            else
            {
                Console.WriteLine("5.no");
            }
            #endregion

            #region Sumar

            //Console.WriteLine($"La tempera 1 se le suma la 2, resulta: {Tempera.Mostrar(tem1 + tem2)}");
            //Console.WriteLine($"La tempera 1 se le suma la 3, resulta: {Tempera.Mostrar(tem1 + tem3)}");
            //Console.WriteLine($"La tempera 1 se le suma la 4, resulta: {Tempera.Mostrar(tem1 + tem4)}");
            //Console.WriteLine($"La tempera 1 se le suma null, resulta: {Tempera.Mostrar(tem1 + null)}");
            #endregion

            Console.WriteLine($"\nLa tempera 1 se le suma 20, resulta: {Tempera.Mostrar(tem1 + 20)}");
            Console.WriteLine($"\nLa tempera 2 se le suma 30, resulta: {Tempera.Mostrar(tem2 + 30)}");

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------\n");

            Paleta paleta1 = 3;
            paleta1 += tem1;
            //Console.WriteLine($"Paleta 1 Despues de sumar tempera 1: {(string)paleta1}");
            //Console.WriteLine($"La paleta 1 y la tempera 1, son iguales? {paleta1 == tem1}");
            paleta1 += tem2;
            //Console.WriteLine($"Paleta 1 Despues de sumar tempera 2: {(string)paleta1}");
            //paleta1 += tem3;
            //Console.WriteLine($"Paleta 1 Despues de sumar tempera 3: {(string)paleta1}");
            //paleta1 += tem4;
            ////Console.WriteLine($"Paleta 1 Despues de sumar tempera 4: {(string)paleta1}");
            //paleta1 += tem5;
            //Console.WriteLine($"Paleta 1 Despues de sumar tempera 5: {(string)paleta1}");

            //Console.WriteLine("\n---------------------------------------------------");
            //Console.WriteLine("---------------------------------------------------\n");

            //paleta1 -= tem1;
            //Console.WriteLine($"Paleta 1 Despues de restar tempera 1: {(string)paleta1}");
            //paleta1 -= tem1;
            //Console.WriteLine($"Paleta 1 Despues de restar tempera 1: {(string)paleta1}");
            //paleta1 -= tem2;
            //Console.WriteLine($"Paleta 1 Despues de restar tempera 2: {(string)paleta1}");
            //paleta1 -= tem5;
            //Console.WriteLine($"Paleta 1 Despues de restar tempera 5: {(string)paleta1}");

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------\n");

            Paleta paleta2 = 2;

            paleta2 += tem5;
            Console.WriteLine($"Paleta 2 Despues de sumar tempera 5: {(string)paleta2}");
            paleta2 += tem4;
            Console.WriteLine($"Paleta 2 Despues de sumar tempera 4: {(string)paleta2}");
            paleta2 += tem3;
            Console.WriteLine($"Paleta 2 Despues de sumar tempera 3: {(string)paleta2}");
            paleta2 += tem2;
            Console.WriteLine($"Paleta 2 Despues de sumar tempera 2: {(string)paleta2}");

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------\n");

            Console.WriteLine($"Suma de ambas paletas: {(string)(paleta1 += paleta2)}");

            Console.WriteLine("\n---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------\n");
            Tempera auxTemp = paleta1[0];

            Console.WriteLine(Tempera.Mostrar(auxTemp));
            Console.WriteLine(paleta1[-5]);
            Console.WriteLine(paleta1[55]);

            paleta1[0] = new Tempera(ConsoleColor.Black, "asado", 100);

            Console.WriteLine(Tempera.Mostrar(paleta1[0]));
            paleta1[-5] = tem2; 








        }
    }
}
