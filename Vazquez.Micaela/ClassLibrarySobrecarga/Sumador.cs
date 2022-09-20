using System;

namespace ClassLibrarySobrecarga
{
    public class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSuma)
        {
            this.cantidadSumas = cantidadSuma;
        }

        public Sumador() 
            : this (0)
        {

        }

        public int GetCantidadSuma()
        {
            return this.cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
           
            return a + b;
        }
    }
}
