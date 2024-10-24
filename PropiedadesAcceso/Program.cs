class Program
{
    public static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado("Axel");
        empleado1.SALARIO = 1200;
        Console.WriteLine("El salario del empleado es: " + empleado1.SALARIO);

        // Incrementando el salario
        empleado1.SALARIO += 500;
        Console.WriteLine("El nuevo salario del empleado es de: " + empleado1.SALARIO);

        // Asignando un salario negativo para comprobar el manejo de excpeciones
        empleado1.SALARIO = -1000;
        Console.WriteLine(empleado1.SALARIO);
        
    }
}

class Empleado
{
    private string _nombre;
    private double _salario;
    public Empleado(string nombre)
    {
        this._nombre = nombre;
    }

    private double EvaluaSalario(double salario)
    {
        if (salario < 0)
        {
            return 0;
        }

        else
        {
            return salario;
        }
    }

    // CREACIÓN DE PROPIEDAD //
/*     public double SALARIO
    {
        get { return this.salario; }
        set { this.salario = EvaluaSalario(value); }
    } */

    // SIMPLIFICANDO LA SINTAXIS DE LA PROPIEDAD //
    public double SALARIO
    {
        get => this._salario;
        set => this._salario = EvaluaSalario(value);
    }

/*     public void SetSalario(double salario)
    {
        if (salario < 0)
        {
            Console.WriteLine("El salario no puede ser negativo");
            this.salario = 0;
        }
        else{
            this.salario = salario;
        }
    }

    public double GetSalario()
    {
        return salario;
    } */
}