using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_I05
{
    public class Tabla
    {
        public static string ArmarTabla(int numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Tabla de multiplicar del numero: {numero}");

            for(int i = 1;i<= 10;i++)
            {
                sb.AppendLine($"{numero} x {i} = {(numero * i)}");

            }
            return sb.ToString();
        }
    }
}
