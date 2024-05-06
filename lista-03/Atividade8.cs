using System;
namespace lista_03;
public class Atividade8
{
    public static void Questao()
    {
        Console.WriteLine("Digite o número de termos da série de Fibonacci que deseja ver:");
        int L = int.Parse(Console.ReadLine());
        long a = 0, b = 1, c = 0;

        Console.WriteLine("Série de Fibonacci até " + L + " termos:");
        for (int i = 1; i <= L; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine();
    }
}