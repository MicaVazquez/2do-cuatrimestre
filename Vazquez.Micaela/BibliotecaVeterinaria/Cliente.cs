using System;

namespace BibliotecaVeterinaria
{
    public class Cliente
    {
        // conocer el domicilio, el nombre y apellido y un teléfono
        private string domicilio;
        private string nombre;
        private string apellido;
        private string telefono;
        public Mascota[] listaMascota ;

        public Cliente(string _domicilio,string _nombre,string _apellido, string _telefono)
        {
            this.domicilio = _domicilio;
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.telefono = _telefono;
            this.listaMascota = new Mascota[3];
        }

        public string Mostrar()
        {
            return $"\n Datos \n-Domicilio: {this.domicilio}\n-Nombre: {this.nombre}\n-Apellido: {this.apellido}\n-Telefono: {this.telefono}";
        }

        public string MostrarMascotas()
        {
            
            string cadenaRetorno = "";
            foreach (Mascota mascota in listaMascota)//a un foreach no se le pueden hacer break
            {
                if (mascota != null)
                {
                    cadenaRetorno += $"\n Mascota\n-Especie: {mascota.GetEspecie()}\n-Nombre: {mascota.GetNombre()}\n-Fecha de nacimiento: {mascota.GetFecha().ToShortDateString()}\n-Vacunas: {mascota.MostrarHistorial()}";
                }
            }
            return cadenaRetorno;
        }

    }
}
