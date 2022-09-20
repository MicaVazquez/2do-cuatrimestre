using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A01
{
    class Calculadora
    {
        public static int Factorial (int numeroI)
        {
            int rtn = 0;// retorno
            int acum = 1;// acumulador
            int i;// contador

            for(i = 1; i <= numeroI; i++)
            {
                acum = acum * i;
            }

            if(acum != 0)
            {
                rtn = acum;
            }
            return rtn;
        }
    }
}
