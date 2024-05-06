using System;
namespace lista_03;
public class Atividade9
{
    public static void Questao()
    {
        Console.WriteLine("Digite o limite L para a soma da série de Fibonacci:");
        long L = long.Parse(Console.ReadLine());
        long a = 0, b = 1, c = 0, sum = 0;

        while (a < L)
        {
            sum += a;
            c = a + b;
            a = b;
            b = c;
        }

        Console.WriteLine("A soma dos elementos da série de Fibonacci menores que " + L + " é: " + sum);
    }
}