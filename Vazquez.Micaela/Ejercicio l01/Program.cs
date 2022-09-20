using System;

namespace Ejercicio_l01
{
    class Program
    {
        static void Main(string[] args)
        {
           float acumPromedio = 0;
            int numeroMayor = 0;
            int numeroMenor = 0;// todas las variables con las que se quiera comparar, igualar, incrementar se deben inicializar
            int auxI;//var auxiliar  para numero ingresado

            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Ingrese un numero:");
                auxI = int.Parse(Console.ReadLine());
                if (i==0)
                {
                    numeroMayor = auxI;
                    numeroMenor = auxI;
                }
                else if(auxI>numeroMayor)
                {
                    numeroMayor = auxI;
                }
                else if (auxI < numeroMenor)
                {
                    numeroMenor = auxI;
                }

                acumPromedio += auxI;
            }

            acumPromedio = acumPromedio / 5;// promedio = (float)acum/5   hay que castear para que se guarde un flotante

            Console.WriteLine("El numero mayor es {0}, el numero menor es {1} y el promedio es {2}", numeroMayor, numeroMenor, acumPromedio);

        }
    }
}
