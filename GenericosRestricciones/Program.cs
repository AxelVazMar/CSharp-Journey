class Program
{
    public static void Main(string[] args)
    {
        // Creando objetos que sí implementan la interface IParaEmpleados
        AlmacenEmpleados<Director> directores = new AlmacenEmpleados<Director>(3);
        directores.Agregar(new Director(2000));
        directores.Agregar(new Director(2500));
        directores.Agregar(new Director(2700));

        AlmacenEmpleados<Secretaria> secretarias = new AlmacenEmpleados<Secretaria>(3);
        directores.Agregar(new Director(2000));
        directores.Agregar(new Director(2500));
        directores.Agregar(new Director(2700));

        AlmacenEmpleados<Electricista> electricistas = new AlmacenEmpleados<Electricista>(3);
        directores.Agregar(new Director(2000));
        directores.Agregar(new Director(2500));
        directores.Agregar(new Director(2700));

        // Tratando de instanciar un objeto que no tiene impletada la interfaz IParaEmpleados
        AlmacenEmpleados<Estudiante> estudiantes = new AlmacenEmpleados<Estudiante>(2);
        estudiantes.Agregar(new Estudiante(2000));
        estudiantes.Agregar(new Estudiante(2500));
        estudiantes.Agregar(new Estudiante(2700));
    }
}

// Creando una clase génerica con restricciones
class AlmacenEmpleados<T> where T : IParaEmpleados
{
    //Esta clase solo podrá instanciar objetos que tengan el método GetSalario
    private int i = 0;
    private T[] datosEmpleado;

    public AlmacenEmpleados(int z)
    {
        datosEmpleado = new T[z];
    }

    public void Agregar(T obj)
    {
        datosEmpleado[i] = obj;
        i++;
    }

    public T GetEmpleado(int i)
    {
        return datosEmpleado[i];
    }
}

class Estudiante
{
    private double edad;
    public Estudiante(double edad)
    {
        this.edad = edad;
    }

    public double GetEdad()
    {
        return edad;
    }
}

class Director : IParaEmpleados 
{
    private double salario;
    public Director(double salario)
    {
        this.salario = salario;
    }

    public double GetSalario()
    {
        return salario;
    }
}

class Secretaria : IParaEmpleados
{
    private double salario;
    public Secretaria(double salario)
    {
        this.salario = salario;
    }

    public double GetSalario()
    {
        return salario;
    }
}

class Electricista : IParaEmpleados
{
    private double salario;
    public Electricista(double salario)
    {
        this.salario= salario;
    }
        
    public double GetSalario()
    {
        return salario;
    }
}

interface IParaEmpleados
{
    double GetSalario();
}