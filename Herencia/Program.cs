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

        /* Accediendo a los métodos del array almacenAnimales y viendo el funcionamineto del polimorfismo */
        for (int i = 0; i < 3; i++)
        {
    
            almacenMamiferos[i].getNombre();
            almacenMamiferos[i].Pensar();
            /* En este caso el método pensar usará el polimorfismo ya que su comportamiento dependerá del
            Objeto almacenado en el array el que determinará la salida de este
            en el Objeto caballo la salida será: "Pensamiento básico instintivo
            en el Objeto Humano la salida será: "Soy capaz de pensar ¿?"
            en el Objeto Gorial la salida será: "Pensamiento instintivo avanzado" */
        }

        //Accediendo a los métodos del dato guardado en el array
        System.Console.WriteLine("\nSaliendo del array");
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

        Ballena miKeiko = new Ballena("Keiko");
        miKeiko.Nadar();
        // Accediendo al método de la interfaz IMamiferosTerrestres
        IMamiferosTerrestres ImiFriezan = Friezan;
        // Accediendo al método de la interfaz ISaltoConPatas
        ISaltoConPatas IFriezan = Friezan;

        // Mostrando el contenido del método NumeroPatas() de la interfaz IMamiferosTerrestres
        Console.WriteLine($"Número de patas de Spirit: " + ImiFriezan.NumeroPatas());

        // Mostrando el contenido del método NumeroPatas() de la interfaz ISaltoConPatas
        Console.WriteLine("Spirit salta con " + IFriezan.NumeroPatas() + " Patas");
        
        


    }
}

/* Creando interfaces */
interface IMamiferosTerrestres
{
    // Método de la interfaz, estas se desarrollan en las clases que ocupen estas inferfaces
    int NumeroPatas();

}

interface IAnimalesDeDeportes
{

    //Interfaz con varios métodos. Esto obliga a que todas las clases que hereden esta interfaz deben implementar todos los métodos
    string TipoDeDeporte();
    bool EsOlimpico();

}

interface ISaltoConPatas
{
    
    // Interfaz con el mismo nombre de método en IMamiferosTerrestres
    int NumeroPatas();

}

/* RESTRICCIONES DE LAS INTERFACES */
/*
1-. No se permite definir variables
2-. No se permite definir constructores
3-. No se permite definir destructores
4-. No se permite definir el modificador de acceso en los métodos (Todos son public de manera implícita)
5-. No se permite crear clases ni ninguna otra estructura dentro de una interfaz
*/

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

    // la palabra reservada virtual sirve para que en la clase padre y sus subclases deberían de tener un método pensar
    // que modifiquen la clase "Pensar"
    // Para hacer esto después de public o antes de la especificación del método se pone la palabra "virtual"
    // Para que la palabra override funcione tenemos que declarar el método de la clase padre como Virtual 
    public virtual void Pensar()
    {
        Console.WriteLine("Pensamiento básico instintivo");
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

//En C# No se permite que una clase herede de múltiples clases, lo que sí se permite es que herede varias INTERFACES
class Caballo : Mamiferos, IMamiferosTerrestres, IAnimalesDeDeportes, ISaltoConPatas
{
    public Caballo(String nombreCaballo) : base(nombreCaballo)
    {

    }
    
    public void Galopar()
    {
        Console.WriteLine("Soy capaz de galopar");
    }

    //Resolviendo ambiguedad de la interfaz IAnimalesTerrestres e ISaltoConPatas 
    // Hay que borrar el modificador de accesos del método y luego poner la interfaz ejemplo: IMamiferosTerrestres.NumeroPatas();
    int IMamiferosTerrestres.NumeroPatas()
    {
        return 4;
    }

    /* Implementando los múltiples métodos de la interfaz IAnimalesDeDeportes */
    public string TipoDeDeporte()
    {
        return "Hípica";
    }

    public bool EsOlimpico()
    {
        return true;
    }

    // Especificando la inmterfaz a la que pertenece el método NumeroPatas()
    int ISaltoConPatas.NumeroPatas()
    {
        return 2;
    } 

}

class Humano : Mamiferos
{

    public Humano(string nombreHumano) : base(nombreHumano)
        {

        }
    // Override sirve para decirle a C# que es el mismo método pero con modificaciones
    public override void Pensar()
        {
            System.Console.WriteLine("Soy capaz de pensar ¿?");
        }
     }

class Gorila : Mamiferos, IMamiferosTerrestres
{
    
    public Gorila(String nombreGorila) : base(nombreGorila)
    {

    }

    public override void Pensar()
    {
        Console.WriteLine("Pensamiento instintivo avanzado");
    }

    public void Trepar()
    {
        Console.WriteLine("Soy capaz de trepar");
    }

    public int NumeroPatas()
    {
        return 2;
    }

}

class Ballena : Mamiferos
{
    public Ballena(string nombreBellena) : base(nombreBellena)
    {

    }

    public void Nadar()
    {
        Console.WriteLine("Soy capaz de nadar");
    }
}