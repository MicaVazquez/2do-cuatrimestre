using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeportes
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioDeGoles;
        private int totalDeGoles;

        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioDeGoles = 0;
            this.totalDeGoles = 0;
        }

        public Jugador(int dni, string nombre) : this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int partidosJugados, int totalDeGoles) : this(dni, nombre)
        {
            this.partidosJugados = partidosJugados;
            this.totalDeGoles = totalDeGoles;
        }

        public float GetPromedioGoles()
        {
            float result = 0f;
            if(totalDeGoles > 0)
            {
                result = this.promedioDeGoles = (float)totalDeGoles / partidosJugados;
            }
            return result;
        }

        public string MostrarDatos()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Jugador\n-Datos:\n dni: {this.dni}\n nombre:{this.nombre}\n -Estadisticas:\n partidos jugados:{this.partidosJugados} \npromedio de goles:{this.promedioDeGoles}\n total goles:{this.GetPromedioGoles()}\n");
            return retorno.ToString();
        }

        public static bool operator != (Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            bool result = false;
            if (j1.dni == j2.dni)
            {
                result = true;
            }
            return result;
        }


    }
}
