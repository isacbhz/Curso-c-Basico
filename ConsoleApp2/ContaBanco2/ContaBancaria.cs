using System;
using System.Globalization;

namespace ContaBanco2
{
    class ContaBancaria
    {
        public int NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double SaldoConta { get; private set; }
        public ContaBancaria(int numConta, string nomeTitular)
        {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }
        public ContaBancaria(int numConta, string nomeTitular, double depIni): this(numConta, nomeTitular)
        {
            Deposito(depIni);
        }
        public void Deposito(double valor)
        {
            SaldoConta += valor;
        }
        public void Saque(double valor)
        {
            SaldoConta -=valor + 5.00;
        }
        public override string ToString()
        {
            return "Conta: "+NumConta+", Titular: "+NomeTitular+", Saldo :$"+SaldoConta.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
