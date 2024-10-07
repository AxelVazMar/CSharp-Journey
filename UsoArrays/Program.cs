class Program
{
    static void Main(string[] args)
    {
        // Primer array
        // int[] edades;
        // edades = new int[4];
        // edades[0] = 15;
        // edades[1] = 27;
        // edades[2] = 19;
        // edades[3] = 80;
        // //edades[4] = 0; => error "IndexOutOfRangeException"
        // Console.Write(edades[2]);

        // Otra mandera de declar e inciar un Array en C#
        // int[] edades = { 15, 27, 19, 80 };
        // System.Console.Write(edades[2]);

        // Array implícito

        //var datos = new[] { "Axel", "Vazquez", "México", 15 }; => error No se encontró el mejor tipo para la matriz con tipo implícito

        var valores = new[] { 15, 28, 35, 7.5, 30.30 }; // Este array no dar error ya que asigna un valor double a todos

        /* Array de objetos */

        Empleados Ana = new Empleados("Ana", 27);
        Empleados[] arrayEmpleados = new Empleados[2];
        arrayEmpleados[0] = new Empleados("Sara", 37); // Almacenando un objeto mientras creamos ese objeto
        arrayEmpleados[1] = Ana;

        /* Array de tripos o clases anónimas */

        var personas = new[]
        {
            new {Nombre = "Juan", Edad = 27}, // => Posición [0] del array
            new {Nombre = "María", Edad = 29}, // => Posiación [1] del array
            new {Nombre = "Diana", Edad = 35} // => Posición [2] del array
        };
        System.Console.WriteLine(personas[2]);
    }

    class Empleados
    {
        public Empleados(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        String nombre;
        int edad;
    }

}