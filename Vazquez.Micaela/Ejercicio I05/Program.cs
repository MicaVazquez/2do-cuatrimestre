using System;

namespace Ejercicio_I05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");

            int numero;

            while (int.TryParse(Console.ReadLine(), out numero))
            {
               
                //recorre desde el 1 hasta el numero ingresado
                for (int centro = 1; centro < numero; centro++)
                {
                    //se suman los numero inferiores al centro
                    int sumaAntes= 0;

                    for (int i = 0; i<centro ; i++)
                    {
                        sumaAntes += i;
                    }

                    //se suman los numeros superiores al centro
                    int sumaDespues = 0;
                    for (int j = centro + 1; j <= sumaAntes ;j++)
                    {
                        if(sumaAntes== sumaDespues || sumaDespues>sumaAntes)// si son iguales o si se pasa que deje de iterar
                        {
                            break;
                        }

                        sumaDespues += j;
                    }


                    //mostrar en pantalla
                    if(sumaAntes == sumaDespues)
                    {
                        Console.WriteLine("Es un centro numerico: {0}", centro);
                    }

                }
            }
            Console.WriteLine("No es un numero...");
            Console.ReadKey();

        }
    }
}
