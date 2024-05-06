using System;
namespace lista_03;
public class Atividade5
{
    public static void Questao()
    {
        Console.WriteLine("Digite um número inteiro e positivo N para calcular E:");
        int N = int.Parse(Console.ReadLine());
        double E = 1; // E começa com 1

        for (int i = 1; i <= N; i++)
        {
            E += 1.0 / Fatorial(i);
        }
        Console.WriteLine("O valor de E é: " + E);
    }

    static long Fatorial(int n)
    {
        long fatorial = 1;
        for (int i = 2; i <= n; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}