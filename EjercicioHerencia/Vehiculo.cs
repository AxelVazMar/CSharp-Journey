using System;

namespace EjercicioHerencia;

public class Vehiculo
{
    private string marcaVehiculo;

    public Vehiculo(string marca)
    {
        marcaVehiculo = marca;
    }

    public void ArrancarMotor()
    {
        Console.WriteLine("ARRANCANDO MOTOR");
        
    }

    public void PararMotor()
    {
        Console.WriteLine("PARANDO MOTOR");
        
    }

    public virtual void Conducir()
    {
        Console.WriteLine("Tipo de conducción del vehiculo");
    }

    public void GetMarca()
    {
         Console.WriteLine($"La marca del vehiculo es: " + marcaVehiculo);
         
    }
}

class Avion : Vehiculo
{
    public Avion(string marca) : base(marca)
    {
        Console.WriteLine("La marca es Boeing");
    }

    public void Despegar()
    {
        Console.WriteLine("Despegando");
    }

    public void Aterrizar()
    {
        Console.WriteLine("Aterrizando"); 
    }

    public override void Conducir()
    {
        Console.WriteLine("Volando");
        
    }
}

class Coche : Vehiculo
{
    public Coche(string marca) : base(marca)
    {
        
    }

    public void Avanzar()
    {
        Console.WriteLine("El coche está avanzando");
    }

    public void Frenar()
    {
        Console.WriteLine("El coche está frenando");
    }

    public override void Conducir()
    {
        Console.WriteLine("Conduciendo");
    }

}
