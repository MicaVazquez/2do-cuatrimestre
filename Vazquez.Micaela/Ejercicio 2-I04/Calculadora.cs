using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_I04
{
    class Calculadora
    {
        public static float Calcular(float primerOperando,float segundoOperando, string operacion)
        {
            float rtn = 0;
            bool rtnValida;

            switch(operacion)
            {
                case "+":
                    rtn = primerOperando + segundoOperando;
                    break;

                case "-":
                    rtn = primerOperando - segundoOperando;
                    break;

                case "*":
                    rtn = primerOperando * segundoOperando;
                    break;

                case "/":
                    rtnValida = Validar(segundoOperando);

                    if (rtnValida == true)
                    {
                        rtn = primerOperando / segundoOperando;
                    }
                    break;
            }

            return rtn;
        }

        private static bool Validar (float segundoOperando)
        {
            bool rtn = false;
            if(segundoOperando != 0)
            {
                rtn = true;
            }
            return rtn;
        }
    }
}
