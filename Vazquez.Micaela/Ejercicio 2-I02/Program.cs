using System;

namespace Ejercicio_2_I02
{
    class Program
    {
        static void Main(string[] args)
        {

            
                int numero1;
                int numero2;
                string respuesta;
                bool rtn;
                int suma = 0;
            do{ 
                Console.WriteLine("Ingrese un numero: ");
                numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese otro numero: ");
                numero2 = int.Parse(Console.ReadLine());

                suma = numero1 + numero2;

                Console.WriteLine("Resultado de la suma: {0}", suma);

                Console.WriteLine("\n ¿Desea continuar? S/N");
                respuesta = Console.ReadLine();
                rtn = Validador.ValidarRespuesta(respuesta);
            } while (rtn == true);

        }
    }
}
