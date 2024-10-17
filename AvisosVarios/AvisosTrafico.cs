using System;

namespace AvisosVarios;

public class AvisosTrafico : IAvisos
{

    // Constructor por defecto
    public AvisosTrafico()
    {
        remitente = "DGT";
        mensaje = "Sanción cometida. Pague antes de 3 días y se le hará un descuento del 50%";
        fecha = "";
    }

    public AvisosTrafico(string remitente, string mensaje, string fecha)
    {

        // Cuando usamos el THIS se refiere al campo de clase no al parámetro del método
        this.remitente = remitente;
        this.mensaje = mensaje;
        this.fecha = fecha;

    }
    public string GetFecha()
    {
        return fecha;
    }

    public void MostrarAviso()
    {

        Console.WriteLine("Mensaje: '{0}' ha sido envíado por {1} con fecha {2}", mensaje, remitente, fecha); // Los números dentro del mensaje se refieren a la posición de los parámetros que le pasamos después de la coma
        
    }

    private string remitente;
    private string mensaje;
    private string fecha;
}
