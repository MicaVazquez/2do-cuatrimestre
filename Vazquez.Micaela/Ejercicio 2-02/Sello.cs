using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_02
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoDeMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();//resetea
        }

        private static string ArmarFormatoDeMensaje()
        {
            string retorno = "";
            int len = Sello.mensaje.Length;
            string bordesCuadro = "";

            if(len>0)
            {
                for(int i = 0; i<len+2 ; i++)
                {
                    bordesCuadro = bordesCuadro + "*";
                }
            }

            retorno = bordesCuadro + "\n" + "*" + Sello.mensaje + "*" + "\n" + bordesCuadro;

            return retorno;
        }
    }
}
