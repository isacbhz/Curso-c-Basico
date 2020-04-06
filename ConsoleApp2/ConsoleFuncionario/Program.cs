using System;
using System.Globalization;

namespace ConsoleFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f;
            f = new Funcionario();

            Console.WriteLine("Dados Funcionario");
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            f.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write(f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porc);
            Console.WriteLine();
            Console.Write("Dados Atualizados: " + f);

            Console.ReadLine();
        }
    }
}
