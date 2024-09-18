namespace Actividad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Dame un numero: ");
            int.TryParse(Console.ReadLine(), out numero);

            if (numero % 2 == 0) Console.WriteLine("El numero " + numero + " es par ");
            else Console.WriteLine("El numero " + numero + " es impar ");

            Console.ReadKey();
        }
    }
}
