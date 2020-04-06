using System;
using System.Collections.Generic;
using System.Text;

namespace Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            Salario *=(porcentagem / 100);
        }
    }
}
