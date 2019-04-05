using System;

namespace StaticLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"8 => {RaizCubica(8)}");
            Console.WriteLine($"9 => {RaizCubica(9)}");
            Console.WriteLine($"10 => {RaizCubica(10)}");
            Console.WriteLine($"11 => {RaizCubica(11)}");

            static double RaizCubica(double valor) => Math.Round(Math.Pow(valor, 1.0 / 3), 2);
        }
    }
}
