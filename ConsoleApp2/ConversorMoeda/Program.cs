using System;
using System.Globalization;
namespace ConversorMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a Cotação do dolar? ");
            double vlrCotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dolares vc vai comprar? ");
            double qteDolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcCotacao = Conversor.Calc(vlrCotacao, qteDolares);

            Console.Write("Valor a ser pago em Reais: "+calcCotacao.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
