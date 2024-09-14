
namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {

            int edad = 28;

            System.Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if (edad >= 18)
            {
                Console.WriteLine("Adelante puedes pasar porque eres mayor de edad");
            }

            System.Console.WriteLine("\nVamos a evaluar si puedes conducir un vehiculo");

            bool licencia = false;

            /* Si un bloque de else o if solo tienen una línea código estos pueden ir sin llaves
            pero lo mas norma es seguir el siguiente patrón
            if(condición) línea_de_código
            */

            if (licencia) System.Console.WriteLine("Puedes conducir vehiculos");

            else System.Console.WriteLine("Lo siento, pero no puedes conducir vehiculos");

            Console.WriteLine("Aquí termina el programa");

            // Usando la instrucción &&

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");

            Console.WriteLine("Introduce tu edad, por favor:");

            int edad2 = Int32.Parse(Console.ReadLine());

            System.Console.WriteLine("¿Tienes licencia?");

            string licencia2 = Console.ReadLine();

            if (edad2 >= 18 && licencia2 == "si")
            {
                Console.WriteLine("Puedes conducir vehículos");
            }

            else
            {
                Console.WriteLine("No puedes conducir vehículos");
            }

        }
    }
}