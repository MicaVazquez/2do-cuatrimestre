using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeportes
{
    public class Equipo
    {
        private List<Jugador> jugadores;
        private short cantidadDeJugadores;
        private string nombre;

        public Equipo()
        {
            this.jugadores = new List<Jugador>();

        }
        public Equipo(short cantidadDeJugadores, string nombre)
        {
            this.cantidadDeJugadores = cantidadDeJugadores;
            this.nombre = nombre;
        }

         public static bool operator +(Equipo e, Jugador j)
        {
            bool result = false;
            bool encontro = false;

            if(e.cantidadDeJugadores > e.jugadores.Count)
            {
                for (int i = 0; i < e.jugadores.Count; i++)
                {
                    if (e.jugadores[i] == j )
                    {
                        encontro = true;
                        break;
                    }
                }

                if(!encontro)
                {
                    e.jugadores.Add(j);
                    result = true;
                }
            }
            return result;
        }
    }
}