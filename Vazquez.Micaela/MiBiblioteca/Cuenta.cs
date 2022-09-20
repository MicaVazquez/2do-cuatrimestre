using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiBiblioteca
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;

        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }
        public float GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"\nEstado de la cuenta \nTitular: {this.titular} \nSaldo: {this.cantidad}\n";
        }

        public void Ingresar(float deposito)
        {
            if(deposito > 0)
            {
               this.cantidad += deposito; 
            }
        }

        public void Retirar(float extraccion)
        {
            this.cantidad -= extraccion;
        }
    }
}
