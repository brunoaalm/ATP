using System;
namespace lista_03;
public class Atividade1
{
	public static void Questao()
	{
        Console.WriteLine("Digite uma sequência de números inteiros separados por espaço:");
        string[] inputs = Console.ReadLine().Split(' ');
        int posCount = 0, negCount = 0, zeroCount = 0;

        foreach (string input in inputs)
        {
            int number = int.Parse(input);
            if (number > 0) posCount++;
            else if (number < 0) negCount++;
            else zeroCount++;
        }

        Console.WriteLine("Positivos: " + posCount);
        Console.WriteLine("Negativos: " + negCount);
        Console.WriteLine("Zeros: " + zeroCount);
    }
}
