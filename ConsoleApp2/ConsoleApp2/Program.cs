using System;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            double media;

            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados primeiro funcionario");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados segundo funcionario");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("Salario media: "+media.ToString("F3",CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
        

    }
}

