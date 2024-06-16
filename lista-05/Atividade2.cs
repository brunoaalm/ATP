using System;
namespace lista_05;
public class Atividade2
{
    public static void Questao()
    {
        // Mensagem explicando a tarefa.
        Console.WriteLine("Faça um procedimento que preencha um vetor com as notas de uma turma de 10 alunos. Faça\r\num outro procedimento que receba um vetor preenchido com as notas, calcule a média da\r\nturma e conte quantos alunos obtiveram nota acima da média. Esse procedimento deve exibir\r\na média e o resultado da contagem. Faça um programa que declare as devidas variáveis e\r\nacione os procedimentos.");
        Console.WriteLine();

        // Declaração do vetor para armazenar as notas dos alunos.
        int[] vetor = new int[10];

        // Chama o método para preencher o vetor com notas aleatórias.
        Preencher(vetor);

        // Chama o método para calcular e exibir a média e o número de alunos acima da média.
        CalcularEExibirResultados(vetor);
    }

    // Procedimento para preencher o vetor com notas aleatórias entre 0 e 10.
    public static void Preencher(int[] vetor)
    {
        Random sorteio = new Random();

        // Loop para preencher cada posição do vetor com uma nota aleatória.
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = sorteio.Next(0, 11); // Gera uma nota entre 0 e 10 (inclusive).
        }

        // Exibe as notas de cada aluno após o preenchimento.
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine("Aluno[{0}] = {1}", i + 1, vetor[i]);
        }
    }

    // Procedimento para calcular a média das notas e contar quantos alunos ficaram acima da média.
    public static void CalcularEExibirResultados(int[] vetor)
    {
        double soma = 0;

        // Calcula a soma das notas.
        for (int i = 0; i < vetor.Length; i++)
        {
            soma += vetor[i];
        }

        // Calcula a média das notas.
        double media = soma / vetor.Length;

        int contador = 0;

        // Conta quantos alunos têm nota maior ou igual à média.
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > media)
            {
                contador++;
            }
        }

        // Exibe a média e o número de alunos acima da média.
        Console.WriteLine("A média da turma foi {0:F2} e {1} alunos ficaram acima da média.", media, contador);
    }
}
