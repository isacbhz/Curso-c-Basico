using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {            
            Console.WriteLine("Entre com os dados do produto");

            Produto p = new Produto("TV", 200.00, 9);
            p.Nome = " ";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);

            Console.ReadLine();
        }
    }
}
