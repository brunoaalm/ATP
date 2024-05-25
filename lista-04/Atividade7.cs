using System;
namespace lista_04;
public class Atividade7
{
    public static void Questao()
    {
        Console.WriteLine("Digite o número de alunos:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite a média do aluno:");
            int media = Convert.ToInt32(Console.ReadLine());

            IdentificarConceito(media);
        }
    }

    static void IdentificarConceito(int media)
    {
        if (media <= 39)
        {
            Console.WriteLine("Conceito: F");
        }
        else if (media <= 59)
        {
            Console.WriteLine("Conceito: E");
        }
        else if (media <= 69)
        {
            Console.WriteLine("Conceito: D");
        }
        else if (media <= 79)
        {
            Console.WriteLine("Conceito: C");
        }
        else if (media <= 89)
        {
            Console.WriteLine("Conceito: B");
        }
        else
        {
            Console.WriteLine("Conceito: A");
        }
    }
}