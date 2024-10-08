namespace Actividad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona profe1 = new Persona();
            Persona profe2 = new Persona();
            Persona profe3 = new Persona();

            profe1.nombre = "Tacio";
            profe1.apellidos = "Camba";
            profe1.edad = 30;

            Console.WriteLine(profe1.Presentarse());
            profe1.EnviarCorreo("Hola mundo");
            Console.WriteLine("El profe es mayor de edad:" + profe1.EsMayorDeEdad());

            profe2.nombre = "Ramon";
            profe2.apellidos = "Rios";
            profe2.edad = 40;

            Console.WriteLine(profe2.Presentarse());
            profe2.EnviarCorreo("Hola mundo");
            Console.WriteLine("El profe es mayor de edad:" + profe2.EsMayorDeEdad());

            profe3.nombre = "Martin";
            profe3.apellidos = "Garcia";
            profe3.edad = 30;

            Console.WriteLine(profe3.Presentarse());
            profe3.EnviarCorreo("Hola mundo");
            Console.WriteLine("El profe es mayor de edad:" + profe3.EsMayorDeEdad());

            Console.ReadLine();
        }
    }
}
