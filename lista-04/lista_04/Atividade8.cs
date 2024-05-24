using System;
namespace lista_04;
public class Atividade8
{
    public static void Questao()
    {
        Console.WriteLine("Digite um valor inteiro e positivo N:");
        int N = Convert.ToInt32(Console.ReadLine());

        double resultado = CalcularS(N);
        Console.WriteLine("O valor de S é: " + resultado);
    }

    static double CalcularS(int N)
    {
        double S = 0;
        for (int i = 1; i <= N; i++)
        {
            S += (Math.Pow(i, 2) + 1) / (i + 3);
        }
        return S;
    }
}
