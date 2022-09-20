using System;

namespace Ejercicio_A01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            factorial = Calculadora.Factorial(numero);

            Console.WriteLine("El factorial de {0} es: {1}", numero, factorial);
        }
    }
}
