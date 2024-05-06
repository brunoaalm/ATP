using System;
namespace lista_03;
public class Atividade7
{
    public static void Questao()
    {
        Console.WriteLine("Digite um valor n inteiro e positivo:");
        int n = int.Parse(Console.ReadLine());
        double S = 0;

        for (int i = 1; i <= n; i++)
        {
            S += 1.0 / i;
            Console.WriteLine("Termo " + i + ": " + (1.0 / i));
        }

        Console.WriteLine("Valor final de S: " + S);
    }
}