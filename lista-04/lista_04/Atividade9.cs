using System;
namespace lista_04;
public class Atividade9
{
    public static void Questao()
    {
        Console.WriteLine("Digite o número de alunos:");
        int N = Convert.ToInt32(Console.ReadLine());

        double media = CalcularMediaAprovados(N);
        Console.WriteLine("A média das notas dos alunos aprovados é: " + media);
    }

    static double CalcularMediaAprovados(int N)
    {
        double soma = 0;
        int count = 0;

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite a nota do aluno:");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota >= 6)
            {
                soma += nota;
                count++;
            }
        }

        return count > 0 ? soma / count : 0;
    }
}
