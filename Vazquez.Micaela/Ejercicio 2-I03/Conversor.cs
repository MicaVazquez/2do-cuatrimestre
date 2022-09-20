using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_I03
{
    class Conversor
    {
        //public string ConvertirDecimalABinario(int numeroEntero) {}

        public string ConvertirDecimalABinario(int numeroEntero)
        {
            string rtn = "";
            int[] vec = 0;
            int resultado;
            int resto;
            int i = 0;

            while(true)
            {
                resultado = numeroEntero / 2;

                resto = numeroEntero % 2;

                if (resto > numeroEntero)
                {
                    break;
                }
                vec[i] = numeroEntero;
                i++;
            }


            return rtn;
        }

        //public int ConvertirBinarioADecimal(int numeroEntero) { }

        public string ConvertirBinarioADecimal(int numeroEntero)
        {
            string rtn = "";

            return rtn;
        }
    }
}
