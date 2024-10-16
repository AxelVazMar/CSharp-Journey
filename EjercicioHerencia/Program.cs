using EjercicioHerencia;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Probando el coche:");
        Coche Coche1 = new Coche("VolksWagen");
        Coche1.ArrancarMotor();
        Coche1.Avanzar();
        Coche1.Conducir();
        Coche1.Frenar();
        Coche1.PararMotor();

        Console.WriteLine("\nProbando el Avión");
        Avion avion1 = new Avion("Boeing");
        avion1.ArrancarMotor();
        avion1.Despegar();
        avion1.Conducir();
        avion1.Aterrizar();
        avion1.PararMotor();

        Vehiculo[] almacenDeVehiculos = new Vehiculo[2];
        almacenDeVehiculos[0] = Coche1;
        almacenDeVehiculos[1] = avion1;
        for (int i = 0; i < almacenDeVehiculos.Length; i++)
        {
            almacenDeVehiculos[i].GetMarca();
            
        } 
        
    }
}