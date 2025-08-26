using System.Globalization;

namespace EjemplosDesdeCasa
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("PROGRAMA DE REVISION DE NOTAS PARA ESTUDIANTES ");

            Console.WriteLine("Ingresa tu nombre estudiante: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Cuantas notas vas a ingresar {name}: ");
            int numberOfGrades = int.Parse(Console.ReadLine());

            double finalGrade = 0;

            for (int i = 1; i <= numberOfGrades; i++)
            {
                Console.WriteLine($"Cual es tu nota # {i}? ");
                double grade =double.Parse(Console.ReadLine());
                Console.WriteLine($"Cual es el porcentaje de la nota # {i}? ");
                double percent = double.Parse(Console.ReadLine());

                double total = grade * percent;
                finalGrade += total;
            }

            if (finalGrade < 3)
            {
                double falledGrade = (3 - finalGrade);
                Console.WriteLine($"Haz perdido la materia, te faltó {falledGrade} para ganarla ");
                Console.WriteLine($"Tu nota fnal es: {finalGrade}");
            }
            else
            {
                Console.WriteLine("Ganaste, felicitaciones!");
                Console.WriteLine($"Tu nota fnal es: {finalGrade}");

            }






        }
    }
}
