using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ContaBanco
{
    public class Conta
    {
        public int NumConta { get; private set; }
        public int NumAgencia { get; private set; }
        public string NomeCliente { get; set; }
        public double Saldo { get; set; }

        public Conta(int numAgencia, int numConta, string nomeCliente, char dep)
        {
            NumAgencia = numAgencia;
            NumConta = numConta;
            NomeCliente = nomeCliente;
            Deposito(dep);
        }
        
        public void Deposito(char saldo)
        {
            if (saldo == 's' || saldo == 'S')
            {
                Console.Write("Entre com um valor para o depósito:");
                Saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }            
        }
        public void Deposito(double valor)
        {
             Saldo +=valor;
        }
        public void Saque(double valor)
        {
            Saldo -=valor + 5.00;
        }
        public override string ToString()
        {
            return "Numero Agencia: "+NumAgencia+ ", Conta: "+NumConta+", Titular: "+NomeCliente+", Saldo $:"+Saldo.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }
}
