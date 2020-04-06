using System;
using System.Collections.Generic;

namespace ExerciciosFixacao_Aula83_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> cursoA = new HashSet<int>();
            HashSet<int> cursoB = new HashSet<int>();
            HashSet<int> cursoC = new HashSet<int>();

            Console.Write("Digite o numero de alunos do curso A: ");
            int numAl = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A: ");
            for (int i = 0; i < numAl; i++)
            {                
                int codAl = int.Parse(Console.ReadLine());
                cursoA.Add(codAl);
            }
            Console.Write("Digite o numero de alunos do curso B: ");
            int numAlb = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B: ");
            for (int i = 0; i < numAlb; i++)
            {
                int codAlb = int.Parse(Console.ReadLine());
                cursoB.Add(codAlb);
            }
            Console.Write("Digite o numero de alunos do curso C: ");
            int numAlc = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C: ");
            for (int i = 0; i < numAlc; i++)
            {
                int codAlc = int.Parse(Console.ReadLine());
                cursoB.Add(codAlc);
            }
            Console.WriteLine();
            HashSet<int> novo = new HashSet<int>();
            novo.UnionWith(cursoA);
            novo.UnionWith(cursoB);
            novo.UnionWith(cursoC);
            Console.Write("Total de Alunos: "+novo.Count);
            Console.ReadLine();
        }
    }
}
