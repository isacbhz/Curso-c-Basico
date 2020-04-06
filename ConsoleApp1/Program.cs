using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,X,Y,Soma,Menor,Maior,Cont;
            Cont = 0;
            Console.WriteLine("digite o numero de repetições: ");
            N = int.Parse(Console.ReadLine());
            if (N != 0)
            {
                do
                {
                    Console.WriteLine("Digite o primeiro numero: ");
                    X = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo numero:");
                    Y = int.Parse(Console.ReadLine());

                    if (X > Y)
                    {
                        Maior = X;
                        Menor = Y;
                    }
                    else
                    {
                        Maior = Y;
                        Menor = X;
                    }
                    Soma = 0;
                    for (int i = Menor + 1; i < Maior; i++)
                    {
                        if (i % 2 != 0)
                        {
                            Soma = Soma + i;
                        }
                    }
                    Console.WriteLine("soma dos numeros ímpares do invervalo entre " + X + " e " + Y + " é = " + Soma);
                    Cont = Cont + 1;
                } while (Cont != N);
            }
            else
            {
                return;
            }
            Console.ReadLine();
        }         
    }
}

