using System;

class Program
{
    public static void Main(string[] args)
    {

        Caballo Friezan = new Caballo("Spirit");
        Humano Juan = new Humano("Juan");
        Gorila Copito = new Gorila("Copito");

        Juan.getNombre();
        Friezan.getNombre();
        Copito.getNombre();

    }
}

class Mamiferos
{

    //creando un campo de clase
    private string nombreSerVivo;

    //creando un constructor por defecto para la clase Mamiferos
    public Mamiferos(String nombre)
    {
        nombreSerVivo = nombre;
    }
    

    public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

    public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mis crías hasta que se puedan valer por sí mismas");
        }

    public void getNombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombreSerVivo);
        }

     }

class Caballo : Mamiferos
    {

        public Caballo(String nombreCaballo) : base(nombreCaballo)
        {

        }

        public void Galopar()
        {
            System.Console.WriteLine("Soy capaz de galopar");
        }
     }

class Humano : Mamiferos
{

        public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
        public void Pensar()
        {
            System.Console.WriteLine("Soy capaz de pensar ¿?");
        }
     }

class Gorila : Mamiferos
{
    
    public Gorila(String nombreGorila) : base(nombreGorila)
    {

    }

    public void Trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }

}