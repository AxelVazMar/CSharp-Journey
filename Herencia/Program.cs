using System;

class Program
{
    public static void Main(string[] args)
    {

        Caballo Friezan = new Caballo("Spirit");
        Humano Juan = new Humano("Juan");
        Gorila Copito = new Gorila("Copito");

        /* Creando arrays con el principio de sutitución */

        Caballo[] almacenAnimales = new Caballo[3];
        almacenAnimales[0] = Friezan;
        //almacenAnimales[1] = Juan; // En este caso el array da error ya que el array que estamos creando es de tipo caballo
        //Por lo que no se pueden alamacernar datos de otro tipo que no sea de tipo Caballo

        Mamiferos[] almacenMamiferos = new Mamiferos[3];
        almacenMamiferos[0] = Friezan;
        almacenMamiferos[1] = Juan;
        almacenMamiferos[2] = Copito;
        /* Este array no da error ya que estamos usando el principio de sustitución ya que el array es de tipo mamiferos
        por lo que será capaz de almacenar datos de tipo Mamiferos */

        //Accediendo a los métodos del dato guardado en el array
        almacenMamiferos[1].getNombre();

        /*Juan.getNombre();
        Friezan.getNombre();
        Copito.getNombre();*/

        /* Principio de sustitución "ES SIEMPRE UN" */
        //Caballo animal = new Mamiferosa("Bucéfalo"); Caso ERRONEO ya que un Mamífero no es siempre un caballo
        //Mamiferos animal = new Caballo("Bucéfalo"); // Caso correcto ya que un Caballo es siempre un Mamífero
        //Mamiferos persona = new Humano("Axel"); // Otro caso correcto ya que una Persona es siempre un Mamífero aunque
        // la clase "Humano" no existe sí que deja usar las propiades generales de la Clase cósmica "Mamiferos"

        /* Instancias donde no usamos el principio de sustitución */
        Mamiferos animal = new Mamiferos("Bucéfalo");
        Caballo Bucefalo = new Caballo("Bucéfalo");
        /* Solo hemos creado instancias pertenecientes a las clases Mamiferos y Caballo */

        /* Aquí sí usamos el principio de sustitución a partir de dos instancias previamente creadas */
        animal = Bucefalo; 
        /* Aquí es válido ya que la variable animal pertenece a la clase mamiferos y 
        la variable Bucefalo pertemece a la clase caballo 
        Por lo que un Caballo es siempre un Mamifero */

        // Bucefalo = animal; Aquí la sintaxis es incorrecta ya que estaríamos diciendo que un Mamifero es siempre un Caballo

        Object miAnimal = new Caballo("Bucefalo");

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