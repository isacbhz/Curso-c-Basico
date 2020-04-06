using System;
using System.Globalization;

namespace ContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==CADASTRO CONTA==");
            Console.Write("Entre com o número da agência: ");
            int numAge = int.Parse( Console.ReadLine());
            Console.Write("Entre com o número da conta: ");
            int numCon = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string nomeTit = Console.ReadLine();
            Console.Write("Haverá depósito Incial? ");
            char depIni = char.Parse(Console.ReadLine());
            Console.WriteLine();

            Conta ct = new Conta(numAge, numCon, nomeTit, depIni);
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(ct);
            Console.WriteLine();

            Console.Write("Entre com um valor para depósito: ");
            ct.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados da Conta: ");
            Console.Write(ct);
            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            ct.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Dados Atualizados da Conta: ");
            Console.Write(ct);

            Console.ReadLine();
        }
    }
}
