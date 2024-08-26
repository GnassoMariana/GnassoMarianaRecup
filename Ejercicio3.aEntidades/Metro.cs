namespace Ejercicio3.aEntidades
{
    public class Metro
    {
        private float longitud;

        public Metro(float longitud =5) 
        {
            this.longitud = longitud; 
        }
        public float GetLongitud() => longitud;

        public static implicit operator float(Metro m)
        {
            return m.longitud;
        }

        public static explicit operator Metro(Yarda y)
        {
            return new Metro((y.GetLongitud()) * 0.9144F);
        }

        public static bool operator ==(Metro m1, Metro m2)
        {
            return m1.longitud == m2.longitud;
        }

        public static bool operator !=(Metro m1, Metro m2)
        {
            return !(m1 == m2);
        }

        public static Metro operator +(Metro m1, Metro m2)
        {
            return new Metro (m1.longitud + m2.longitud);
        }

        public static Metro operator +(Metro m, Yarda y)
        {
            return m + (Metro)y;
        }
    }
}
