using System;

namespace BibliotecaClass7
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            return $"\nTempera: \n-Color: {this.color}\n-Marca: {this.marca} \n-Cantidad: {this.cantidad}";
        }

        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostrar();
        }


        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            bool result = false;

            if(tempera1 is null && tempera2 is null)
            {
                result = true;
            }
            else if (tempera1 is not null && tempera2 is not null)
            {
                result = (tempera1.color == tempera2.color && tempera1.marca == tempera2.marca);
            }
            return result;

        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }


        public static implicit operator int(Tempera tempera)
        {
            return tempera is null ? 0 : tempera.cantidad;
        }

        public static Tempera operator +(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {
                tempera1 = tempera1 + tempera2.cantidad;
            }
            return tempera1;
        }

        public static Tempera operator +(Tempera tempera, int cant)
        {
            //tempera.cantidad += cant; esta mal

            //return tempera;

            return new Tempera(tempera.color, tempera.marca, tempera.cantidad + cant);

        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public ConsoleColor Color
        {
            get { return color; }
            set { color = value; }
        }

    }

}

