using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        //SOBRECARGA EN METODOS
        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        
        private string Mostrar()
        {
            return $"{this.cadena} - {this.entero} - {this.fecha.ToShortDateString()}";
        }

        public static string Mostrar(Cosa obj)
        {
            //return  $"{obj.cadena} - {obj.entero} - {obj.fecha.ToShortDateString()}";//NO REUTILIZA
            return obj.Mostrar();
        }

        //SOBRECARGA EN CONSTRUCTORES
        public Cosa(DateTime fecha, int entero, string cadena) : this (entero, cadena)
        {
            this.fecha = fecha;
            this.entero = entero;
            this.cadena = cadena;
        }

        public Cosa(int entero, string cadena): this(cadena)
        {
            this.entero = entero;
        }

        public Cosa (string cadena): this()
        {
            this.cadena = cadena;
        }

        public Cosa ()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }
        
        
    }
}
