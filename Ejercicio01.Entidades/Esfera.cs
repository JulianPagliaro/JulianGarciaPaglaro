namespace Ejercicio01.Entidades
{
    public class Esfera
{
    private readonly int _radio;
    private readonly double _diametro;

    public Esfera(int radio)
    {
        if (radio <= 0)
        {
            throw new ArgumentException("El radio debe ser mayor que 0");
        }
        _radio = radio;
        _diametro = 2 * radio;
    }

    public double CalcularArea() => 4 * Math.PI * Math.Pow(_radio, 2);

    public double CalcularVolumen() => (4.0 / 3.0) * Math.PI * Math.Pow(_radio, 3);

    public string MostrarDatos()
    {
        string mensaje =
            "Los datos de la piramide cuadrada son: \n" +
            $"\t radio= {_radio} \n" +
            $"\t diametro= {_diametro} \n" +
            $"\t Area= {CalcularArea()} \n" +
            $"\t Volumen = {CalcularVolumen()} ";
        return mensaje;
    }
}
}
