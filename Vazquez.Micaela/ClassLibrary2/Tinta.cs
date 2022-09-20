using System;

namespace ClassLibrary2
{
    public class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color) : this()
        {
            this.color = color;
        }
        public Tinta(ConsoleColor color, ETipoTinta tipo) : this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            return $"\n Color: {this.color} \n Tipo: {this.tipo}";
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1,Tinta tinta2)
        {
            return tinta1.tipo == tinta2.tipo && tinta1.color == tinta2.color;
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1.tipo == tinta2.tipo && tinta1.color == tinta2.color);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();//?
        }


    }
}
