using System;

namespace PropertyPatterns
{
    class Program
    {
        static void Main()
        {
            Passagem p1 = new Passagem() { SiglaRegiao = "NE", PrecoBase = 200.0 };
            Console.WriteLine($"Passagem 1 - Região: {p1.SiglaRegiao}, " +
                $"Preço Base: {p1.PrecoBase}, Preço Final: " + AplicarAdicional(p1));

            Passagem p2 = new Passagem() { SiglaRegiao = "SE", PrecoBase = 50.0 };
            Console.WriteLine($"Passagem 2 - Região: {p2.SiglaRegiao}, " +
                $"Preço Base: {p2.PrecoBase}, Preço Final: " + AplicarAdicional(p2));
        }

        private static double AplicarAdicional(Passagem passagem) =>
            passagem switch
        {
            { SiglaRegiao: "N" } => passagem.PrecoBase * 1.5,
            { SiglaRegiao: "NE" } => passagem.PrecoBase * 1.4,
            { SiglaRegiao: "CO" } => passagem.PrecoBase * 1.3,
            { SiglaRegiao: "S" } => passagem.PrecoBase * 1.1,
            _ => passagem.PrecoBase
        };
    }

    public class Passagem
    {
        public string SiglaRegiao { get; set; }
        public double PrecoBase { get; set; }
    }
}
