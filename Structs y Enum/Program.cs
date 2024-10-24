class Program
{
    public static void Main(string[] args)
    {
        Empleado empleado1 = new Empleado(1200, 250);
        empleado1.CambiaSalario(empleado1, 100);
        Console.WriteLine(empleado1);
    }
}

public struct Empleado
{
    public double salarioBase, comision;

    public Empleado(int salarioBase, int comision)
    {
        this.salarioBase = salarioBase;
        this.comision = comision;
    }

    public override string ToString()
    {
        return string.Format("Salario y comisón del empleado: {0},{1}", this.salarioBase, this.comision);
    }

    public void CambiaSalario(Empleado emp, double incremento)
    {
        emp.salarioBase += incremento;
        emp.comision += incremento;
    }
}
