namespace Ejercicio02.Entidades
{
    public static class ValidadorCUILCUIT
    {

        public static bool Validar(string cuilCuit, Tipo tipo)
        {
            if (string.IsNullOrEmpty(cuilCuit) || cuilCuit.Length != 13)
            {
                return false;
            }


            if (cuilCuit[2] != '-' || cuilCuit[11] != '-')
            {
                return false;
            }


            string[] partes = cuilCuit.Split('-');
            if (partes.Length != 3)
            {
                return false;
            }


            if (!int.TryParse(partes[0], out int tipoNumero) ||
                !long.TryParse(partes[1], out long numero) ||
                !int.TryParse(partes[2], out int digitoVerificador))
            {
                return false;
            }

            if (tipoNumero != (int)tipo)
            {
                return false;
            }


            return VerificarDigitoVerificador(partes[0] + partes[1], digitoVerificador);
        }
        public enum Tipo
        {
            Empresa = 30,
            Hombre = 20,
            Mujer = 27
        }

        private static bool VerificarDigitoVerificador(string numero, int digitoVerificador)
        {
            int[] multiplicadores = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            int suma = 0;

            for (int i = 0; i < multiplicadores.Length; i++)
            {
                suma += (numero[i] - '0') * multiplicadores[i];
            }

            int resto = suma % 11;
            int digitoCalculado = resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;

            return digitoCalculado == digitoVerificador;
        }

        private static string ObtenerTipo(int tipoNumero)
        {
            return tipoNumero switch
            {
                20 => "Hombre",
                27 => "Mujer",
                30 => "Empresa"

            };
        }
    }
}
