using System;

namespace Ejercicio_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Los cuatro primeros numeros perfectos: ");

            int contador = 0;
            int i = 2;

            while(contador != 4)
            {
                int verifica = 0;

                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        verifica += j;
                    }
                }

                if(i==verifica)
                {
                    Console.WriteLine(i);
                    contador++;
                }

                i++;
            }
        }
    }
}
