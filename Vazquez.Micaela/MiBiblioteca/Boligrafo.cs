using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Boligrafo
    {   
        const short cantidadTintaMaxima = 100;

        //ATRIBUTO

        private ConsoleColor color;
        private short tinta;

        //METODOS

        public Boligrafo(short tinta,ConsoleColor color)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        public bool Pintar(short gasto, out string dibujo)//ese parametro que va  a permitir una salida de informacion
        {
            bool rtn = true;
            dibujo = "";

            if(this.tinta <= 0)// si no tiene mas tinta
            {
                rtn = false;
            }
            else
            {
                if(gasto <= this.tinta)
                {
                    this.SetTinta(Convert.ToInt16(gasto * -1));

                    for(int i = 0;i<gasto;i++)
                    {
                        dibujo += "*";
                    }
                }
                else
                { // si se deasea gastar mas

                    for (int i = 0; i < this.tinta; i++)
                    {
                        dibujo += "*";
                    }
                    this.SetTinta(Convert.ToInt16(this.tinta * -1));
                }
            }


            return rtn;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        private void SetTinta(short tinta)
        {
            int resultante;
            if(tinta <= 0)// si lo que recibe es negativo == Quitar tinta
            {
                short aRestar = Convert.ToInt16(tinta * -1);
                resultante = this.tinta - aRestar;

                if(resultante >= 0 && resultante <= 100)
                {
                    this.tinta -= aRestar;
                }
            }
            
        }
        
    }
}
