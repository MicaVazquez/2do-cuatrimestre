using System;

namespace Ejercicio_I06
{
    class Program
    {
        static void Main(string[] args)
        {
            int aInicio;
            int aFin;
            int flag = 0;
            Console.WriteLine("Ingrese un año de inicio: ");
            aInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un año de fin: ");
            aFin = int.Parse(Console.ReadLine());

            for(int i = aInicio; i<aFin; i++)
            {
                if(i%4 == 0)
                {
                    if(flag == 0)
                    {

                        Console.WriteLine("Años bisiestos: ");
                        flag = 1;
                    }
                    Console.WriteLine(i);
                }
            }


        }
    }
}
