using Ejercicio3.Entidades;
using MiDLL.dll;

namespace Ejercicio2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isbn = ConsoleExtensions.ReadString("Ingresar el codigo isbn");
            Console.WriteLine($"{ValidadorISBN.EsValido(isbn)}");
        }
    }
}
