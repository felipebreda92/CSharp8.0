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

        public static double? AreaSwitch(FiguraGeometrica? figura, double medida1 = 0, double? medida2 = null)
        {
            switch(figura, medida1)
            {
                case (FiguraGeometrica.Quadrado, 1):
                    return medida1 * medida1;
                case (FiguraGeometrica.Retangulo, 2):
                    return medida1 * medida2.Value;
                case (FiguraGeometrica.Triangulo , 3):
                    return (medida1 * medida2.Value) / 2.0;
                case (null, 0):
                    throw new ArgumentException("Valores Inválidos");
            }
            return 0;
        }
    }
}

