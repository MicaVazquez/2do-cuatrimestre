using System;
using MiBiblioteca;

namespace Ejercicio_3_I03
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante obj1 = new Estudiante("Agustin","Rivola","12378");
            Estudiante obj2 = new Estudiante("Leonel","Verza","13451");
            Estudiante obj3 = new Estudiante("Camilo","Echeverry","12298");

            obj1.SetNotaPrimerParcial(7);
            obj1.SetNotaSegundoParcial(8);

            Console.WriteLine(obj1.Mostrar());

            obj2.SetNotaPrimerParcial(4);
            obj2.SetNotaSegundoParcial(6);

            Console.WriteLine(obj2.Mostrar());

            obj3.SetNotaPrimerParcial(2);
            obj3.SetNotaSegundoParcial(3);

            Console.WriteLine(obj3.Mostrar());
        }
    }
}
