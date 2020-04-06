using System;
using System.Globalization;

namespace ConsoleAlunoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do Aluno");
            Aluno a;
            a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno " + a.Nome);
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine(a);
            
            if (a.Aprovado() == true)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado!");
                Console.WriteLine("Faltaram "+a.RestanteNota().ToString("F2",CultureInfo.InvariantCulture) +" Pontos");
            }
            Console.ReadLine();
        }
    }
}
