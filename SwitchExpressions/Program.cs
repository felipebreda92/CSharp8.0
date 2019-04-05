using System;

namespace SwitchExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var area = Calculos.Area(FiguraGeometrica.Quadrado, 2);
                Console.WriteLine($"A area de um quadrado quem tem lado 2 é {area}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
