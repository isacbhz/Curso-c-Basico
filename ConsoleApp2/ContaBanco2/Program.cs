using System;
using System.Globalization;

namespace ContaBanco2
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria ct;
            Console.Write("Entre o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?");
            char depIni = char.Parse(Console.ReadLine());

            if (depIni == 's' || depIni == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double vlrDep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ct = new ContaBancaria(numConta, nomeTitular, vlrDep);
            }
            else
            {
                ct = new ContaBancaria(numConta, nomeTitular);
            }
            Console.Write("Dados da Conta: ");
            Console.Write(ct);
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            ct.Deposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados:");
            Console.Write(ct);
            Console.WriteLine();
            Console.Write("Entre um valor para saque:");
            ct.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados:");
            Console.Write(ct);
            Console.ReadLine();
        }
    }
}
