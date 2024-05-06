using System;
namespace lista_03;
public class Atividade2
{
    public static void Questao()
    {
        Console.WriteLine("Digite uma sequência de números inteiros separados por espaço:");
        string[] inputs = Console.ReadLine().Split(' ');
        int totalNumbers = inputs.Length;
        int posCount = 0, negCount = 0, zeroCount = 0;

        foreach (string input in inputs)
        {
            int number = int.Parse(input);
            if (number > 0) posCount++;
            else if (number < 0) negCount++;
            else zeroCount++;
        }

        Console.WriteLine("Percentual de Positivos: " + (posCount * 100.0 / totalNumbers) + "%");
        Console.WriteLine("Percentual de Negativos: " + (negCount * 100.0 / totalNumbers) + "%");
        Console.WriteLine("Percentual de Zeros: " + (zeroCount * 100.0 / totalNumbers) + "%");
    }
}
