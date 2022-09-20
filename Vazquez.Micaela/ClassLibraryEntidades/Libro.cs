using System;
using System.Text;
namespace ClassLibraryEntidades
{
    public class Libro
    {
        private Autor autor;
        private int cantidadDePaginas;
        private static Random generadorDePaginas;
        private float precio;
        private string titulo;

        public int CantidadPaginas
        {
            get 
            {
                if(this.cantidadDePaginas == 0)
                {
                    this.cantidadDePaginas = generadorDePaginas.Next(10, 570);
                }
                return this.cantidadDePaginas; 
            }
        }

        public static explicit operator string(Libro libro)
        {
            return Mostrar(libro);//?
        }

        static Libro()
        {
            generadorDePaginas = new Random();
        }

        public Libro(float precio, string titulo, Autor autor)
        {
            this.autor = autor;
            this.precio = precio;
            this.titulo = titulo;
        }

        public Libro(string titulo, string apellido, string nombre, float precio) : this(precio, titulo, new Autor(nombre, apellido))//?
        {

        }

        private static string Mostrar (Libro l)
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Informacion del libro:\n Autor:{l.autor} \n Titulo: {l.titulo}\n Cantidad de paginas: {l.cantidadDePaginas}\n Precio: {l.precio}\n" );
            return retorno.ToString();
        }

        public static bool operator ==(Libro libro1, Libro libro2)
        {
            bool result = false;

            if(libro1 is null && libro2 is null)
            {
                result = true;
            }

            if(libro1.autor == libro2.autor && libro1.titulo == libro2.titulo)
            {
                result = true;
            }
            return result;
        }

        public static bool operator !=(Libro libro1, Libro libro2)
        {
            return !(libro1 == libro2);
        }

    }

}