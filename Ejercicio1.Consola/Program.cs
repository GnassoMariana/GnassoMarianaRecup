using Ejercicio1.Entidades;
using MiDLL.dll;

namespace Ejercicio1.Consola
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var radio = ConsoleExtensions.ReadInt("Ingresar el valor del radio:");
                var altura = ConsoleExtensions.ReadInt("Ingresar el valor de la altura:");
                Cilindro c = new Cilindro(radio, altura);
                Console.WriteLine($"{c.MostrarDatos()}");
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
