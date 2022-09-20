using System;

namespace Ejecicio_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int opcion;
            string entrada;
            bool resultado;
            int flag = 0;
            Console.WriteLine("Ingrese un numero positivo o escriba salir: ");
            entrada = Console.ReadLine();
            resultado = int.TryParse(entrada, out num);

            while(entrada != "salir" && resultado == false)
            {
                Console.WriteLine("Ingrese un numero positivo o escriba salir: ");
                entrada = Console.ReadLine();

            }

            for(int i=1;i<= num;i++)
            {
                int contador = 0;

                for(int j = 1; j <= i;j++)
                {
                    if(i % j==0)
                    {
                        if(flag == 0)
                        {
                            Console.WriteLine("Numeros primos hasta el numero {0}",num);
                            flag = 1;
                        }
                        contador++;
                    }
                }

                if(contador <=2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("¿Desea volver a operar?\n1. Si \n2. No\n Opcion: ");


            while(!(int.TryParse(Console.ReadLine(),out opcion)) || (opcion != 1 && opcion != 2))
            {
                Console.WriteLine("Esa opcion no es correcta!\n¿Desea volver a operar?\n(1) Si \n (2) No\n Opcion: ");

            }

            if(opcion == 1)
            {
                Main(args);
            }
        }
    }
}
