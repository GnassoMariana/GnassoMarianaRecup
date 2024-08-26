using Ejercicio3.aEntidades;

namespace Ejercicio3.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metro metro = new Metro(1);
            Metro metro2= new Metro(10);
            Yarda yarda = new Yarda(1);
            Yarda yarda2 = new Yarda(10);
            Yarda yarda3 = new Yarda(1);
            float resultado = 0;
            resultado = metro + metro2;
            Console.WriteLine($"Suma de metros: {resultado}");
            Console.WriteLine($"Comparacion metros: {metro == metro2}");
            resultado = metro + yarda;
            Console.WriteLine($"Suma entre metros y yardas: {resultado} metros");
          


        }
    }
}
