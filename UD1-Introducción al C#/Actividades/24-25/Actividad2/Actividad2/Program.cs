namespace Actividad2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cont;

            cont = 1;

            cont = cont + 5;

            cont = cont + 5;

            cont++;




            float num1, num2, num3, num4, num5, promedio;

            Console.Write("Inserta un numero:");
            if (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ha habido un error a la hora de hacer la conversion");
            }

            Console.Write("Inserta un numero:");
            if (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ha habido un error a la hora de hacer la conversion");
            }

            Console.Write("Inserta un numero:");
            if (!float.TryParse(Console.ReadLine(), out num3))
            {
                Console.WriteLine("Ha habido un error a la hora de hacer la conversion");
            }

            Console.Write("Inserta un numero:");
            if (!float.TryParse(Console.ReadLine(), out num4))
            {
                Console.WriteLine("Ha habido un error a la hora de hacer la conversion");
            }

            Console.Write("Inserta un numero:");
            if (!float.TryParse(Console.ReadLine(), out num5))
            {
                Console.WriteLine("Ha habido un error a la hora de hacer la conversion");
            }

            promedio = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine("El promedio de los numeros es: " + promedio);
            Console.ReadKey();
        }
    }
}
