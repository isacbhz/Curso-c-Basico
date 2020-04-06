using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Retangulo
{
    class Retangulo
    {
        public double Base;
        public double Altura;

        public double Area()
        {
            return Base * Altura;
        }
        public double Perimetro()
        {
            return (Base + Altura) * 2;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2));
        }
        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture)
                +"\nPERÍMETRO = "+Perimetro().ToString("F2",CultureInfo.InvariantCulture)
                +"\nDIAGONAL = "+Diagonal().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
