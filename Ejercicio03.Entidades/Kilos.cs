namespace Ejercicio03.Entidades
{
    public class Kilos
    {
        private float peso;
        public float GetPeso() => peso;

        public Kilos(float peso = 5)
        {
            this.peso = peso;
        }
        public static implicit operator float(Kilos kilos)
        {
            return kilos.peso;
        }

        public static bool operator ==(Kilos k1, Kilos k2)
        {
            return k1.peso == k2.peso;
        }

        public static bool operator !=(Kilos k1, Kilos k2)
        {
            return !(k1.peso == k2.peso);
        }

        public override bool Equals(object? obj)
        {
            if (obj is null || !(obj is Kilos kilos)) return false;
            return this.Equals(kilos);
        }
        public override int GetHashCode()
        {
            return this.peso.GetHashCode();
        }

        public static explicit operator Kilos(Libras lb)
        {
            return new Kilos(lb.GetPeso() * 0.45359237f);
        }

        public static bool operator ==(Kilos k, Libras l)
        {
            return k == (Kilos)l;
        }

        public static bool operator !=(Kilos k, Libras l)
        {
            return !(k == (Kilos)l);
        }

        public static Kilos operator +(Kilos k1, Kilos k2)
        {
            return new Kilos(k1.peso + k2.peso);
        }

        public static Kilos operator +(Kilos k1, Libras l)
        {
            return new Kilos(k1.peso + (Kilos)l);
        }
    }
}
