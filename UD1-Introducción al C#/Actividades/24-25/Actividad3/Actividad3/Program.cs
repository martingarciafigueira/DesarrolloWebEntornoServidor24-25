namespace Actividad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;

            Console.WriteLine("Dame un numero");
            float.TryParse(Console.ReadLine(), out num1);

            Console.WriteLine("Dame un numero");
            float.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.WriteLine("La resta es: " + (num1 - num2));
            Console.WriteLine("La division es: " + (num1 / num2));
            Console.WriteLine("La multiplicacion es: " + (num1 * num2));
            Console.ReadKey();

        }
    }
}
