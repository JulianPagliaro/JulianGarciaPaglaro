namespace Ejercicio03.Entidades
{
    public class Libras
    {
        private float peso;
        public float GetPeso() => peso;

        public Libras(float peso = 5)
        {
            this.peso = peso;
        }

        public static implicit operator float(Libras libras)
        {
            return libras.peso;
        }
        public static bool operator ==(Libras f1, Libras f2)
        {
            return f1.peso == f2.peso;
        }

        public static bool operator !=(Libras f1, Libras f2)
        {
            return !(f1.peso == f2.peso);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Libras libras)) return false;
            return this.Equals(libras);
        }
        public override int GetHashCode()
        {
            return this.peso.GetHashCode();
        }

        public static explicit operator Libras(Kilos kg)
        {
            return new Libras(kg.GetPeso() * 2.20462262f);
        }

        public static bool operator ==(Libras l, Kilos k)
        {
            return l == (Libras)k;
        }

        public static bool operator !=(Libras l, Kilos k)
        {
            return !(l == (Libras)k);
        }

        public static Libras operator +(Libras l1, Libras l2)
        {
            return new Libras(l1.peso + l2.peso);
        }

        public static Libras operator +(Libras l1, Kilos k)
        {
            return new Libras(l1.peso + (Libras)k);
        }
    }
}
