class Program
{
    public static void Main(string[] args)
    {
        // Creando el array de tipo empleados y declarando que este array contendrá 4 elementos
        AlmacenObjetos<Empleado> empleados = new AlmacenObjetos<Empleado>(4);
        /*empleados.Agregar(new Empleado(2000));
        empleados.Agregar(new Empleado(3500));
        empleados.Agregar(new Empleado(1000));
        empleados.Agregar(new Empleado(9090));
        Empleado salarioEmpleado = empleados.GetElemento(2);
        Console.WriteLine(salarioEmpleado.GetSalario());*/

        // Creando el array de tipo strings
        AlmacenObjetos<String> nombres = new AlmacenObjetos<String>(4);
        nombres.Agregar("Axel");
        nombres.Agregar("Sandra");
        nombres.Agregar("Juan");
        nombres.Agregar("Rusty");
        String nombrePersona = nombres.GetElemento(2);
        Console.WriteLine(nombrePersona);

        // Creando un array de tipo DatTime
        AlmacenObjetos<DateTime> fecha = new AlmacenObjetos<DateTime>(4);
        fecha.Agregar(new DateTime());
        fecha.Agregar(new DateTime());
        fecha.Agregar(new DateTime());
        fecha.Agregar(new DateTime());
        DateTime fechaActual = fecha.GetElemento(2);
        Console.WriteLine(fechaActual);

    }
}

class AlmacenObjetos <T>
/* Una clase génerica se declara con "<T>" */
{
    private T[] datosElemento;
    private int i = 0;
    public AlmacenObjetos(int z)
    {
        datosElemento = new T[z];
    }

    public void Agregar(T obj)
    {
        datosElemento[i] = obj;
        i++;
    }

    public T GetElemento(int i)
    {
        return datosElemento[i];
    }
}

class Empleado
{
    private double salario;
    public Empleado(double salario)
    {
        this.salario = salario;
    }

    public double GetSalario()
    {
        return salario;
    }
}