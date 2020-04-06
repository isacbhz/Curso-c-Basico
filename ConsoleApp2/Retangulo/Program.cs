using System;
using System.Globalization;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Digite a Altura e Base do retângulo");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Base = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r.Area();
            r.Perimetro();
            r.Diagonal();
            Console.WriteLine(r);
           
            Console.ReadLine();
        }
    }
}
