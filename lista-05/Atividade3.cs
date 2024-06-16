using System;
namespace lista_05;
public class Atividade3
{
    public static void Questao()
    {
        // Mensagem explicando a tarefa.
        Console.WriteLine("Preencha um vetor X de 10 elementos. Copie os valores negativos para um novo vetor e exiba ambos.");

        // Declaração do vetor X para armazenar 10 elementos.
        int[] vetorX = new int[10];

        // Chama o procedimento para preencher o vetor com valores fornecidos pelo usuário.
        PreencherVetor(vetorX);

        // Chama a função para copiar valores negativos para um novo vetor.
        int[] vetorNegativos = CopiarNegativos(vetorX);

        // Exibe o vetor original e o vetor de valores negativos.
        Console.WriteLine("Vetor X (original):");
        ExibirVetor(vetorX);

        Console.WriteLine("Vetor de valores negativos:");
        ExibirVetor(vetorNegativos);
    }
    public static void PreencherVetor(int[] vetor)
    {
        Console.WriteLine("Digite 10 valores para o vetor:");

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }

    // Função que recebe um vetor e retorna um novo vetor com os valores negativos.
    public static int[] CopiarNegativos(int[] vetor)
    {
        // Conta quantos valores negativos existem para alocar o novo vetor.
        int countNegativos = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < 0)
            {
                countNegativos++;
            }
        }

        // Cria o vetor para os valores negativos.
        int[] vetorNegativos = new int[countNegativos];
        int index = 0;

        // Copia os valores negativos para o novo vetor.
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] < 0)
            {
                vetorNegativos[index] = vetor[i];
                index++;
            }
        }

        return vetorNegativos;
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
