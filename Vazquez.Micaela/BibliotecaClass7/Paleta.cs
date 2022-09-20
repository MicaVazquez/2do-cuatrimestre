using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClass7
{
    public class Paleta
    {
        private List<Tempera> lista;
        private int cantidadColores;


        private Paleta()
        {
            this.lista = new List<Tempera>();
        }

        private Paleta(int cantidadColores) : this()
        {
            this.cantidadColores = cantidadColores;
        }


        public static implicit operator Paleta(int cant)
        {
            return new Paleta(cant);
        }

        private string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Tiene un total de {this.cantidadColores} colores.");

            foreach (Tempera tempera in this.lista)
            {
                retorno.AppendLine(Tempera.Mostrar(tempera));
            }

            return retorno.ToString();
        }

        private int obtenerIndice(Tempera tempera)
        {
            int rtn = -1;
            if(tempera is not null)
            {
                for(int i = 0; i<this.lista.Count; i++)
                {
                    if(this.lista[i] == tempera)
                    {
                        rtn = i;
                        break;
                    }
                }
            }
            return rtn;
        }

        public static explicit operator string(Paleta paleta)
        {
            return paleta.Mostrar();//?
        }

        public static bool operator ==(Paleta paleta, Tempera tempera)
        {
            bool result = false;
            
            if(paleta.obtenerIndice(tempera) > -1)
            {
                result = true;
            }
            return result;
        }

        public static bool operator !=(Paleta paleta, Tempera tempera)
        {
            return !(paleta == tempera);
        }

        public static Paleta operator +(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.obtenerIndice(tempera);
            if (indice > -1)
            {
                paleta.lista[indice] += tempera;
            }
            else
            {
                if(paleta.cantidadColores > paleta.lista.Count)
                {
                    paleta.lista.Add(tempera);
                }
            }
            return paleta;
        }

        public static Paleta operator -(Paleta paleta, Tempera tempera)
        {
            int indice = paleta.obtenerIndice(tempera);

            if (indice > -1)
            {
                paleta.lista[indice] += (-tempera);

                if (paleta.lista[indice] <= 0)
                {
                    paleta.lista.RemoveAt(indice);
                }
            }

            return paleta;
        }

        public static Paleta operator +(Paleta paleta1, Paleta paleta2)
        {
            int cantMax = paleta1.cantidadColores + paleta2.cantidadColores;
            
            Paleta paleta3 = new(cantMax);

            paleta3.lista = paleta1.lista;

            foreach (Tempera tempera in paleta2.lista)
            {
                paleta3 += tempera;
            }
            return paleta3;
        }

           public Tempera this[int index]
           {
               get
               {
                  if(index < 0 || index > this.lista.Count)
                  {
                    return null;
                  }
                  return this.lista[index];
               }

               set
               {

                if(!(index < 0 || index > this.lista.Count))
                {
                    this.lista[index] = value;
                }

               }
           }


        public int CantidadTemperas
        {
            get { return cantidadColores; }
            set { cantidadColores = value; }
        }


    }
}
