class Program 
{
    public static void Main(string[] args)
    {
        Coche coche1 = new Coche(); // Aquí hemos instaciado nuestra clase coche, con la palabra New hemos llamado al constructor => crear objeto/instancia de tipo coche y dar un estado inicial a nuestro coche

        Coche coche2 = new Coche();
        System.Console.WriteLine(coche1.getInfoCoche());
        System.Console.WriteLine(coche2.getInfoCoche());

        Coche coche3 = new Coche(4500.25, 1200.25);
        System.Console.WriteLine(coche3.getInfoCoche());

    }
}

class Coche
{
    public Coche()
    {
        ruedas = 4;

        largo = 2300.5;

        ancho = 0.800;
    }

    // Sobrecarga de constructores

    public Coche(double anchoCoche, double largoCoche)
    {
        ruedas = 4;
        ancho = anchoCoche;
        largo = largoCoche;
    }


    /* A estos tipos de métodos se les llama getters porqué es a través de estos métodos que podemos acceder a las caraterísticas
    de nuestros objetos para así tener un mejor control y no modificar a diestra y siniestra
    get = dame
    */
    public string getInfoCoche()
    {
        return "Información del coche:\n" + "Ruedas: " + ruedas + "\nLargo: " + largo + "\nAncho: " + ancho;
    }
    
    private int ruedas;
    private double largo;
    private double ancho;
    private bool aireAcondicionado;
    private string tapiceria;
}