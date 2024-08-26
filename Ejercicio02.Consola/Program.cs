
using Ejercicio02.Entidades;
using System.Security.Cryptography;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el tipo (Empresa (30), Hombre (20), Mujer (27):");
            string? tipoInput = Console.ReadLine();

            Console.WriteLine("Ingrese un CUIL/CUIT (formato XX-XXXXXXXX-X):");
            string? cuilCuit = Console.ReadLine();

            
            ValidadorCUILCUIT.Tipo tipo;
            if (!Enum.TryParse(tipoInput, true, out tipo))
            {
                Console.WriteLine("Tipo inválido.");
                return;
            }

            bool esValido = ValidadorCUILCUIT.Validar(cuilCuit, tipo);

            if (esValido)
            {
                Console.WriteLine($"El CUIL/CUIT {cuilCuit} es válido para el tipo {tipo}.");
            }
            else
            {
                Console.WriteLine($"El CUIL/CUIT {cuilCuit} es inválido para el tipo {tipo}.");
            }
        }
    }
}