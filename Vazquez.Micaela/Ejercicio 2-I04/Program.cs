using System;

namespace Ejercicio_2_I04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            string operacion;
            float resultado; 

            Console.WriteLine("Ingrese primer numero: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese segundo numero: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese operacion que desea realizar (+,-,*,/)");
            operacion = Console.ReadLine();

            resultado = Calculadora.Calcular(numero1, numero2, operacion);

            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}
