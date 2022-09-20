using System;

namespace ClassLibraryEntidades
{
    public class Autor
    {
        private string apellido;
        private string nombre;

        public Autor(string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public static implicit operator string(Autor a)
        {
            return a.nombre + a.apellido;
        }

        public static bool operator ==(Autor autor1, Autor autor2)
        {
            bool result = false;

            if(autor1.apellido == autor2.apellido && autor1.nombre == autor2.nombre)
            {
                result = true;
            }

            if(autor1 is null && autor2 is null)
            {
                result = true;
            }

            return result;
        }

        public static bool operator !=(Autor autor1, Autor autor2)
        {
            return !(autor1 == autor2);
        }


    }
}
