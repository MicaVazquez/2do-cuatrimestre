using System;
using System.Text;

namespace MiBiblioteca
{
    public class Estudiante
    {
        //ATRIBUTOS
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //METODOS
        public double CalcularNotaFinal()
        {
            float promedio;
            double numeroAleatorio = -1;

            promedio = this.CalcularPromedio(); 
            if(promedio >= 4)
            {
                numeroAleatorio = Estudiante.random.Next(6, 10);
            }
            return numeroAleatorio;
        }

        private float CalcularPromedio()
        {
            int suma;
            float promedio;
            suma = this.notaPrimerParcial + this.notaSegundoParcial;
            
            promedio = suma / 2.0f;

            return promedio;
        }

        //CONSTRUCTORES
        static Estudiante()//es privado
        {
            Estudiante.random = new Random();//inicializa con new
        }

        public Estudiante(string nombre,string apellido,string legajo)//de instancia o no estatico
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string Mostrar()
        {
            double notaFinal;
                        StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre + ", "+ this.apellido + " legajo: " + this.legajo);
            sb.AppendLine("Nota primer parcial: " + notaPrimerParcial.ToString());//convierte todo a string
            sb.AppendLine("Nota segundo parcial: " + notaSegundoParcial.ToString());
            sb.AppendLine("Promedio: " + CalcularPromedio().ToString());

            notaFinal = this.CalcularNotaFinal();

            if(notaFinal != -1)
            {
                sb.AppendLine("Nota final: " + CalcularNotaFinal().ToString());
            }
            else
            {
                sb.AppendLine("Alumno desaprobado.");
            }
            
            return sb.ToString(); 
        }

        //SETTERS
        public void  SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
    }
}
