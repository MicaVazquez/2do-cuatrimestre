using System;

namespace Ejercicio_I02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cuadrado;
            int cubo;
            
            Console.WriteLine("Ingrese un numero positivo:");

            num = int.Parse(Console.ReadLine());

            while(num<0)
            {
                Console.WriteLine("Error.Reingresar numero");
                Console.WriteLine("Ingrese un numero:");

                num = int.Parse(Console.ReadLine());
            }
            
            cuadrado = (int)Math.Pow(num, 2);
            cubo =(int) Math.Pow(num, 3);

            Console.Write("Cuadrado del numero: {0}\n", cuadrado);
            Console.Write("Cubo del numero: {0}", cubo);
        }
    }
}
