using System;

namespace Ejercicio_2_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string tabla;
            Console.WriteLine("Ingrese un numero entero: ");
            numero= int.Parse(Console.ReadLine());

            tabla = Tabla.ArmarTabla(numero);
            Console.WriteLine(tabla);

           
        }
    }
}
