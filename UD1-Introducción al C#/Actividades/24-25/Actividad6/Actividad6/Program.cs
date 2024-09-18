namespace Actividad6;

class Program
{
    static void Main(string[] args)
    {
        byte numero;
        Console.Write("Inserta un número: ");
        byte.TryParse(Console.ReadLine(), out numero);

        switch (numero)
        {
            case 1: Console.WriteLine("LUNES"); break;
            case 2: Console.WriteLine("MARTES"); break;
            case 3: Console.WriteLine("MIERCOLES"); break;
            case 4: Console.WriteLine("JUEVES"); break;
            case 5: Console.WriteLine("VIERNES"); break;
            case 6: Console.WriteLine("SABADO"); break;
            case 7: Console.WriteLine("DOMINGO"); break;
            default: Console.WriteLine("INSERTE UN NUMERO DEL 1 AL 7"); break;
        }
        Console.ReadKey();
    }
}
