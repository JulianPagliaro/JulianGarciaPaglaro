using Ejercicio03.Entidades;
using RecuperatorioPrimerParcialPooTema1;

namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kilos kilos = new Kilos(3);
            Libras libras = new Libras(6);

            Console.WriteLine($"Kilos: {kilos.GetPeso()}");
            Console.WriteLine($"Libras: {libras.GetPeso()}");


            Kilos kilosConverted = (Kilos)libras;
            Libras librasConverted = (Libras)kilos;

            Console.WriteLine(
                $"Libras convertido a Kilos: {kilosConverted.GetPeso()}");
            Console.WriteLine(
                $"Kilos convertido a Libras: {librasConverted.GetPeso()}");

            Kilos sumaKilos = kilos + kilosConverted;
            Libras sumaLibras = libras + librasConverted;

            Console.WriteLine($"Suma de Kilos: {sumaKilos.GetPeso()}");
            Console.WriteLine($"Suma de Libras: {sumaLibras.GetPeso()}");

            // Comparaciones
            Console.WriteLine(
                kilos == kilosConverted
                ? "Los pesos en Kilos son iguales."
                : "Los pesos en Kilos no son iguales.");
            Console.WriteLine(
                libras == librasConverted
                ? "Los pesos en Libras son iguales."
                : "Los pesos en Libras no son iguales.");

            ConsoleExtensions.EsperarPresionDeTecla(" ");


        }
    }
}

  