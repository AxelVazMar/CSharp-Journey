
using System.Runtime.Intrinsics.Arm;

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

            if (licencia) Console.WriteLine("Puedes conducir vehiculos");

            else Console.WriteLine("Lo siento, pero no puedes conducir vehiculos");

            // Usando la instrucción &&

            Console.WriteLine("Vamos a evaluar si puedes conducir un vehículo");

            Console.WriteLine("Introduce tu edad, por favor:");

            int edad2 = Int32.Parse(Console.ReadLine());

            if (edad2 < 18) Console.WriteLine("No puedes conducir vehiculos");

            else
            {
                Console.WriteLine("¿Tienes carnet?");

                string licencia2 = Console.ReadLine();

                int compara = String.Compare(licencia2, "si", true);

                if (compara == 0) Console.WriteLine("Puedes conducir vehiculos");

                else Console.WriteLine("Lo siento, pero no puedes conducir");
            }

            //Utilizando el operador lódgico "O" usando "||"

            Console.WriteLine("\nIntroduce el primer parcial");
            float parcial1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo parcial");
            float parcial2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el tercer parcial");
            float parcial3 = Int32.Parse(Console.ReadLine());

            if (parcial1 >= 5 || parcial2 >= 5 || parcial3 >= 5) System.Console.WriteLine("La nota media es: " + (parcial1 + parcial2 + parcial3) / 3);

            else System.Console.WriteLine("No pasaste");

            // Utilizando la estructura else if

            System.Console.WriteLine("\nIntroduce tu edad");
            int edad3 = Int32.Parse(Console.ReadLine());

            if (edad3 < 18) Console.WriteLine("Eres un niño");

            else if (edad3 < 30) Console.WriteLine("Eres un joven");

            else if (edad3 < 60) Console.WriteLine("Eres maduro");

            else Console.WriteLine("Debes cuidarte ya");
        }
    }
}