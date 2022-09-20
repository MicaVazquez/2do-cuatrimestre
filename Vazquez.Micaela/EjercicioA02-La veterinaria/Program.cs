using System;
using BibliotecaVeterinaria;

namespace EjercicioA02_La_veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente1 = new Cliente("San luis 470", "Natalia", "Vazquez", "4566-7890");
            Cliente cliente2 = new Cliente("Galigniana 1148", "Agustin", "Rivola", "4578-6889");
            Cliente cliente3 = new Cliente("Flores 415", "Ana", "Montenegro", "4298-7890");


            cliente1.listaMascota[0] = new Mascota("perro", "Santi", new DateTime(2017,06,13));

            cliente2.listaMascota[0] = new Mascota("gato", "Tomi", new DateTime(2017, 06, 14));

            
            cliente3.listaMascota[0] = new Mascota("gato", "Pi", new DateTime(2015, 06, 13));
            cliente3.listaMascota[1] = new Mascota("perro", "Fatiga", new DateTime(2012, 06, 13));

            cliente1.listaMascota[0].historialVacunacion[0] = "sin vacunas";

            cliente2.listaMascota[0].historialVacunacion[0] = "triple felina";

            cliente3.listaMascota[0].historialVacunacion[0] = "sin vacunas";
            cliente3.listaMascota[1].historialVacunacion[0] = "vacuna contra la rabia";

            
            Console.WriteLine(cliente1.Mostrar());
            Console.WriteLine(cliente1.MostrarMascotas());

            Console.WriteLine(cliente2.Mostrar());
            Console.WriteLine(cliente2.MostrarMascotas());

            Console.WriteLine(cliente3.Mostrar());
            Console.WriteLine(cliente3.MostrarMascotas());

        }
    }
}
