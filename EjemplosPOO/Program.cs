namespace EjemplosPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Circulo miCirculo; // Creación de objeto de tipo círculo => Variable/objeto de tipo círculo
            miCirculo = new Circulo(); // Iniciación de variable/objeto de tipo círculo => Instanciar una clase => Instanciación => Ejemplarización => Creación de ejemplar de clase
            Console.WriteLine(miCirculo.CalculoArea(5));

            Circulo miCirculo2 = new Circulo(); // Al igual que con las variables podemos iniciar un objeto en la misma línea
            Console.WriteLine(miCirculo2.CalculoArea(9));
            Console.WriteLine(miCirculo.CalculoArea(5));

        }
    }

    class Circulo
    {
        const double pi = 3.1416; // Propiedad de la clase Círculo => Campos de clase

        public double CalculoArea(int radio) // <= Método de clase => Comportamiento de la clase
        {
            return pi * radio * radio;
        }
    }
}