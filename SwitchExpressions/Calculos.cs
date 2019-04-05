using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchExpressions
{
    public static class Calculos
    {
        public static double? Area
            (FiguraGeometrica figura, double medida1, double? medida2 = null) =>
        figura switch
        {
            FiguraGeometrica.Quadrado => medida1 * medida1,
            FiguraGeometrica.Retangulo => medida1 * medida2.Value,
            FiguraGeometrica.Triangulo => (medida1 * medida2.Value) / 2.0,
            _ => throw new ArgumentException("Figura Geométrica inválida!")
        };
    }
}

