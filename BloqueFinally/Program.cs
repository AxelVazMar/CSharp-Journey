class Program
{
    static void Main(string[] args)
    {
        System.IO.StreamReader archivo = null;

        try
        {
            string linea;

            int contandor = 0;

            string path = @"D:\C# Projects\C#-Journey\BloqueFinally\archivo.txt";
            archivo = new System.IO.StreamReader(path);

            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);

                contandor++;
            }

        }
        catch (Exception e)
        {
            System.Console.WriteLine("Error con la lectura del archivo");
        }
        finally
        {
            if (archivo != null)
            {
                archivo.Close();
                System.Console.WriteLine("Archivo cerrado");
            }
        }
    }
}
