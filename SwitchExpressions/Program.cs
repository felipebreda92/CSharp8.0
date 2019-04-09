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

                var areaSwitch = Calculos.AreaSwitch(FiguraGeometrica.Quadrado, 1);
                Console.WriteLine($"Area calculada por um switch case: {areaSwitch}");
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
