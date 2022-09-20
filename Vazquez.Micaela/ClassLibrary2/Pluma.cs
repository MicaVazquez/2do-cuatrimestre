using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma (string marca): this()
        {
            this.marca = marca;
        }
        public Pluma(string marca, Tinta tinta) : this(marca)
        {
            this.tinta = tinta;
        }
        public Pluma(string marca, Tinta tinta, int cantidad) : this(marca,tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return $"\n Marca: {this.marca} \n Cantidad: {this.cantidad} \n Informacion de la tinta: {(string)tinta}\n";
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma == tinta;
        }

        public static bool operator != (Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma == tinta)
            {
                pluma.cantidad++;
            }
            return pluma;
        }

        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad--;
            }
            return pluma;
        }

        public static implicit operator string(Pluma pluma)
        {
            return pluma.Mostrar();
        }





    }
}
