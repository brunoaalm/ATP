using System;
namespace lista_05;
public class Atividade2
{
    public static void Questao()
    {
        int[] vetor = new int[10];
        Preencher(vetor);
        Imprimir(vetor);

    }

    public static void Preencher(int[] vetor)
	{
		Random sorteio = new Random();
		for (int i = 0; i < 10; i++)
		{
			vetor[i] = sorteio.Next(0,10);
        }
    }

    public static void Imprimir(int[] vetor)
    {

        for (int i = 0; i < 10; i++)
        {
            int aluno = i + 1;
            Console.WriteLine("Aluno[{0}]= {1}",aluno, vetor[i]);
        }

        double media = 0;
        double soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        media = soma / 10;

        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] >= 6)
            {
                contador++;
            }
        }
        Console.WriteLine("A média dos alunos foram {0} e {1} alunos ficaram acima da média", media, contador);
    }

    public double CalculaMedia(int[] vetor)
	{
        double media = 0;
        double soma = 0;

        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }
        media = soma / 10;
        return media;
    }
}
