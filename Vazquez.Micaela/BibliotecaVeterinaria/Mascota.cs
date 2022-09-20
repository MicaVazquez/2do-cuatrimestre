using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaVeterinaria
{
    public class Mascota
    {
        //mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y su historial de vacunación. 
        private string especie;
        private string nombre;
        private DateTime fechaNacimiento;
        public string[] historialVacunacion;

       
        public Mascota(string _especie, string _nombre, DateTime _fechaNacimiento)
        {
            this.especie = _especie;
            this.nombre = _nombre;
            this.fechaNacimiento = _fechaNacimiento;
            this.historialVacunacion = new string[3];
        }

        public string GetEspecie()
        {
            return this.especie;
        }
        public string GetNombre()
        {
            return this.nombre;
        }
        public DateTime GetFecha()
        {
            return this.fechaNacimiento;
        }

        public string MostrarHistorial()
        {

            string cadenaRetorno = "";
            foreach (string historial in historialVacunacion)//a un foreach no se le pueden hacer break
            {
                if (historial != null)
                {
                    cadenaRetorno += $"{historial}";
                }
            }
            return cadenaRetorno;
        }

    }
}
