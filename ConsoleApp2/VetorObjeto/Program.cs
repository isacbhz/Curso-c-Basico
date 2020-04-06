using System;
using System.Globalization;

namespace VetorObjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a quantidade de produtos: ");
            int n = int.Parse(Console.ReadLine());
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o nome do "+(i+1)+" produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço $ do produto " + name+": ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };               
            }
            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = 0.0;
            avg = sum / n;

            Console.WriteLine("Average Price: "+avg.ToString("F2",CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
