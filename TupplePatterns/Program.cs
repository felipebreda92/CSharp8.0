using System;

namespace TupplePatterns
{
    class Program
    {
        private static double ConverteMedidas
               (Medida alturaOriginal, Medida alturaResultado, double valor) =>
            (alturaOriginal, alturaResultado) switch
        {
            (Medida.Pes, Medida.Metros) => Math.Round(valor * 0.3048, 4),
            (Medida.Metros, Medida.Pes) => Math.Round(valor * 3.281, 2),
            (_, _) => throw new ArgumentException("Converao Inválida")
        };

        static void Main(string[] args)
        {
            double valor;

            valor = 10;
            Console.WriteLine($"Pés: {valor}, " +
                $"Metros: {ConverteMedidas(Medida.Pes, Medida.Metros, valor) }");

            valor = 30.48;
            Console.WriteLine($"Metros: {valor}, " +
                $"Pés: {ConverteMedidas(Medida.Metros, Medida.Pes, valor) }");
        }
    }

    public enum Medida
    {
        Metros,
        Pes
    }
}
