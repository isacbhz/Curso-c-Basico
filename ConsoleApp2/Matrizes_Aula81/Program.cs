using System;

namespace Matrizes_Aula81
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de linhas: ");
            int nLin = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de colunas: ");
            int nCol = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] mat = new int[nLin, nCol];

            for (int i = 0; i < nLin; i++)
            {
                Console.Write("Digite " + nCol + " numeros para a linha " + (i + 1) + ": ");
                string[] lin = Console.ReadLine().Split(' ');
                for (int j = 0; j < nCol; j++)
                {
                    mat[i, j] = int.Parse(lin[j]);
                }
                
            }
            Console.Write("Digite um numero da matriz: ");
            int nMat = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < nLin; i++)
            {
                for (int j = 0; j < nCol; j++)
                {
                    if (mat[i,j]==nMat)
                    {
                        Console.WriteLine();
                        Console.Write("Position: " +i+","+j+":");
                        Console.WriteLine();
                        if (j > 0)
                        {
                            Console.WriteLine("Left: "+mat[i,j-1]);
                        }
                        if (j < nCol -1)
                        {
                            Console.WriteLine("Right: "+mat[i,j+1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: "+mat[i-1,j]);
                        }
                        if (i < nLin -1)
                        {
                            Console.WriteLine("Down :"+mat[i+1,j]);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
