using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.aEntidades
{
    public class Yarda
    {
        private float longitud;

        public Yarda(float longitud =5)
        {
            this.longitud = longitud;
        }
        public float GetLongitud() => longitud;

        public static implicit operator float(Yarda y)
        {
            return y.longitud;
        }

        public static explicit operator Yarda(Metro m)
        {
            return new Yarda((m.GetLongitud()) * 1.09361F);
        }

        public static bool operator ==(Yarda y1, Yarda y2)
        {
            return y1.longitud == y2.longitud;
        }

        public static bool operator !=(Yarda y1, Yarda y2)
        {
            return !(y1 == y2);
        }

        public static Yarda operator +(Yarda y1, Yarda y2)
        {
            return new Yarda(y1.longitud + y2.longitud);
        }

        public static Yarda operator +( Yarda y, Metro m)
        {
            return y + (Yarda)m;
        }
    }
}
