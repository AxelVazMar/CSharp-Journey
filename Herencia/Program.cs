using System;

class Program
{
    public static void Main(string[] args)
    {

        Caballo Friezan = new Caballo();
        Humano Juan = new Humano();
        Gorila Copito = new Gorila();

        
        Console.WriteLine();

    }
}

class Mamiferos
{
    public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

    public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se puedan valer por sí mismas");
        }

     }

    class Caballo : Mamiferos
    {
        public void Galopar()
        {
            System.Console.WriteLine("Soy capaz de galopar");
        }
     }

    class Humano : Mamiferos
     {
        public void Pensar()
        {
            System.Console.WriteLine("Soy capaz de pensar ¿?");
        }
     }

    class Gorila : Mamiferos
     {
        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
     }