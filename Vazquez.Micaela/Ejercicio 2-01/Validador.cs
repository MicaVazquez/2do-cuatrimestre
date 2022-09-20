using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_01
{
    class Validador
    {
       /// <summary>
       /// Valida valor entre minimo y maximno
       /// </summary>
       /// <param name="valor"></param>
       /// <param name="min"></param>
       /// <param name="max"></param>
       /// <returns>  devuelve true si se encuentra dentro del rango y si no es asi false</returns>
        public static Boolean Validar(int valor,int min,int max)
        {
            bool resultado = false;
            if(valor>=min && valor<=max)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
