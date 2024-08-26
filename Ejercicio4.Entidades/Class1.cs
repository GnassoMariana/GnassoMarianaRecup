namespace Ejercicio4.Entidades
{
    public class NumeroDivCincoSiete
    {
        public int Valor { get; set; }

        public NumeroDivCincoSiete(int valor)
        {
            if (Validar(valor))
            {
                Valor = valor;
            }
        }
        public bool Validar(int valor)
        {
            if(valor%5 == 0 && valor%7 ==0)
            {
                return true;
            }
            return false;
        }

        public static bool operator==(NumeroDivCincoSiete n1, NumeroDivCincoSiete n2)
        {
            return n1.Valor == n2.Valor;
        }

        public static bool operator !=(NumeroDivCincoSiete n1, NumeroDivCincoSiete n2)
        {
            return !(n1 == n2);
        }

        public override bool Equals(object? obj)
        {
            if(obj is null || !(obj is NumeroDivCincoSiete numDiv)) return false;
            return this == numDiv;
        }
        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Valor}";
        }
    }
}
