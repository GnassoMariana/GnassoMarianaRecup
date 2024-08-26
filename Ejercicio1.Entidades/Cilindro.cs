using System.Text;

namespace Ejercicio1.Entidades
{
    public class Cilindro
    {
        private readonly int radio;
        private double diametro;
        private int altura;

        public int GetRadio() => radio;
        public double GetDiametro() => diametro;
        

        public Cilindro(int radio, int altura)
        {
            if(radio < 0 || altura < 0)
            {
                throw new ArgumentException("El radio y la altura deben ser mayores a cero");
            }
            this.radio = radio;
            diametro = radio * 2;
            this.altura = altura;
        }

        public double GetArea()
        {
            return 2 * Math.PI * radio * (radio + altura);
        }

        public double GetVolumen()
        {
            return Math.PI * Math.Pow(radio, 2) * altura;
        }

        public string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine("Datos del cilindro:");
            datos.AppendLine($"Radio: {radio}");
            datos.AppendLine($"Altura: {altura}");
            datos.AppendLine($"Diametro: {diametro}");
            datos.AppendLine($"Area: {GetArea()}");
            datos.AppendLine($"Volumen: {GetVolumen()}");

            return datos.ToString();
        }

    }
}
