using System;

namespace Ejercicio_I07
{
    class Program
    {
        static void Main(string[] args)
        {
           
                int valorHora;
                string nombre;
                int antig;
                int cantHoras;
               
                string confirma;

            do
            {
                int totalHoras = 0;
                int totalAntig = 0;
                int importeBruto = 0;
                int importeNeto = 0;
                //valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas

                Console.WriteLine("Ingrese el valor de la hora: ");
                valorHora = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el nombre: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese los años de antiguedad: ");
                antig = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese cantidad de horas trabajadas: ");
                cantHoras = int.Parse(Console.ReadLine());

                // (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13 % en concepto de descuentos.

                totalHoras = valorHora * cantHoras;
                totalAntig = antig * 150;
                importeBruto = totalHoras + totalAntig;
                importeNeto = importeBruto - (importeBruto * 13 / 100);

                // el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto
                Console.Write("\n-----------------------------------------");
                Console.Write("\nNombre: {0}", nombre);
                Console.Write("\nEl valor de la hora: {0} ", valorHora);
                Console.Write("\nTotal a cobrar en bruto: {0} ", importeBruto);
                Console.Write("\nTotal a cobrar neto: {0} ", importeNeto);
                Console.WriteLine("\n-----------------------------------------");


                Console.WriteLine("\n\n Desea ingresar otro empleado? Escriba:\n -si \n -no");
                confirma = Console.ReadLine();
            } while (confirma == "si");
            

        }
    }
}
