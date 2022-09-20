using System;

namespace Ejercicio_2_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = 100;
            int minimo = -100;
            int numeroMenor = 0;
            int numeroMayor = 0;
            
            int acum = 0;
            bool resultado;
            float promedio;

            for(int i = 0;i<10;i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                
                resultado = Validador.Validar(numero, minimo, maximo);


                if(resultado == true)
                {
                    Console.WriteLine("Numero correcto!");
                    acum += numero;

                    if(i == 0)
                    {
                        numeroMayor = numero;
                        numeroMenor = numero;
                    }
                    else if(numero<numeroMenor)
                    {
                        numeroMenor = numero;
                    }
                    else if(numero>numeroMayor)
                    {
                        numeroMayor = numero;
                    }

                   
                }
                else
                {
                    Console.WriteLine("Numero incorrecto!");
                }

            }

            promedio = (float) acum / 10;

            Console.WriteLine("El valor minimo ingresado: {0}", numeroMenor);
            Console.WriteLine("El valor maximo ingresado: {0}", numeroMayor);
            Console.WriteLine("El promedio: {0}",promedio);
        }
    }
}
