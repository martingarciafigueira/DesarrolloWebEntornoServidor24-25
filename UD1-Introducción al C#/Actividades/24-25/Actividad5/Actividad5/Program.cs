namespace Actividad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numero;
            char calificacion;

            Console.Write("Introduce tu nota: ");
            byte.TryParse(Console.ReadLine(), out numero);

            if (numero >= 90) calificacion = 'A';
            else if (numero >= 80) calificacion = 'B';
            else if (numero >= 70) calificacion = 'C';
            else if (numero >= 60) calificacion = 'D';
            else calificacion = 'F';

            Console.WriteLine("Tu calificación es: " + calificacion);

            Console.ReadKey();
        }
    }
}
