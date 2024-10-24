namespace EnumFundamentos
{
    /* Creando un enmu */
    enum Estaciones { Primavera, Verano, Otoño, Invierno };
    enum Bonus { bajo = 500, normal = 1000, bueno = 1500, extra = 3000 };

    class Program
    {
        static void Main(string[] args)
        {
            /* Creando un variable de tipo Estaciones */
            Console.WriteLine("\n// ------------ Estaciones ----------------- //\n");
            Estaciones alergia = Estaciones.Primavera;
            Console.WriteLine(alergia);  

            /* Convirtiendo un objeto de tipo enum a string */
            string laAlergia = alergia.ToString();
            Console.WriteLine(laAlergia);

            /* Convirtiendo a null un objeto de tipo enum */
            Estaciones? enfermedades = null;

            Console.WriteLine("\n// ------------ BONUS ----------------- //\n");
            Bonus Antonio = Bonus.bajo;
            Console.WriteLine(Antonio);

            // Almacenando el valor númerico del bonus de Antonio en este caso 1500 //
            double bonusAntonio = (double)Antonio; // Convirtiendo un enum a double
            Console.WriteLine(bonusAntonio);
            double salarioAntonio = 1500 + bonusAntonio; // Operando con el tipo enum convertido a double
            Console.WriteLine("El salario de Antonio es de: " + salarioAntonio);

            Console.WriteLine("\n// ------------ BONUS CLASE EMPLEADO --------------- //\n");
            Empleado Axel = new Empleado(Bonus.extra, 1900.5);
            Console.WriteLine("El salario del empleado es: " + Axel.GetSalario());
            
            
        }   
    }

    class Empleado
    {
        private double salario, bonus;

        // Trabajando sobre una de clase que manda a llamar a un tipo enum
        public Empleado(Bonus bonusEmpleado, double salario)
        {
            bonus = (double)bonusEmpleado;
            this.salario = salario;
        }

        public double GetSalario()
        {
            return salario + bonus;
        }
    }
}