using System;
namespace lista_04;
public class Atividade1
{
    public static void Questao()
    {
        Console.WriteLine("Digite o número de alunos:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite as 3 notas do aluno:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite 'A' para média aritmética ou 'P' para média ponderada:");
            char opcao = Convert.ToChar(Console.ReadLine().ToUpper());

            CalcularMedia(nota1, nota2, nota3, opcao);
        }
    }

    static void CalcularMedia(double nota1, double nota2, double nota3, char opcao)
    {
        double media = 0;

        if (opcao == 'A')
        {
            media = (nota1 + nota2 + nota3) / 3;
        }
        else if (opcao == 'P')
        {
            media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        Console.WriteLine("A média do aluno é: " + media);
    }
}
