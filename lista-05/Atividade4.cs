using System;
namespace lista_05;
public class Atividade4
{
    public static void Questao()
    {
        // Mensagem explicando a tarefa.
        Console.WriteLine("Preencha dois vetores X e Y com 10 elementos cada. Gere um novo vetor com os elementos intercalados de X e Y e exiba os três vetores.");
        Console.WriteLine();

        // Declaração dos vetores X e Y para armazenar 10 elementos cada.
        int[] vetorX = new int[10];
        int[] vetorY = new int[10];

        // Chama o procedimento para preencher os vetores X e Y com valores fornecidos pelo usuário.
        PreencherVetores(vetorX, vetorY);

        // Chama a função para gerar um novo vetor com os elementos intercalados de X e Y.
        int[] vetorIntercalado = GerarVetorIntercalado(vetorX, vetorY);

        // Exibe os vetores X, Y e o vetor intercalado.
        Console.WriteLine("Vetor X:");
        ExibirVetor(vetorX);

        Console.WriteLine("Vetor Y:");
        ExibirVetor(vetorY);

        Console.WriteLine("Vetor Intercalado:");
        ExibirVetor(vetorIntercalado);
    }
    public static void PreencherVetores(int[] vetorX, int[] vetorY)
    {
        Console.WriteLine("Digite 10 valores para o vetor X:");
        for (int i = 0; i < vetorX.Length; i++)
        {
            Console.Write($"Elemento X[{i + 1}]: ");
            vetorX[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite 10 valores para o vetor Y:");
        for (int i = 0; i < vetorY.Length; i++)
        {
            Console.Write($"Elemento Y[{i + 1}]: ");
            vetorY[i] = int.Parse(Console.ReadLine());
        }
    }

    // Função que recebe dois vetores e retorna um novo vetor com os elementos intercalados.
    public static int[] GerarVetorIntercalado(int[] vetorX, int[] vetorY)
    {
        // Cria um vetor com o dobro do tamanho para armazenar os elementos intercalados.
        int[] vetorIntercalado = new int[vetorX.Length + vetorY.Length];

        // Preenche o vetor intercalado.
        for (int i = 0; i < vetorX.Length; i++)
        {
            vetorIntercalado[2 * i] = vetorX[i]; // Posições pares recebem elementos de X.
            vetorIntercalado[2 * i + 1] = vetorY[i]; // Posições ímpares recebem elementos de Y.
        }

        return vetorIntercalado;
    }

    // Procedimento para exibir o conteúdo de um vetor.
    public static void ExibirVetor(int[] vetor)
    {
        if (vetor.Length == 0)
        {
            Console.WriteLine("O vetor está vazio.");
        }
        else
        {
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Elemento[{0}] = {1}", i, vetor[i]);
            }
        }
    }
}
