using System;
namespace lista_05;
public class Atividade8
{
    public static void Questao()
    {
        // Cria uma matriz 4x4 para armazenar os valores.
        int[,] matriz = new int[4, 4];

        // Chama o procedimento para preencher a matriz com valores fornecidos pelo usuário.
        PreencherMatriz(matriz);

        // Exibe a matriz.
        Console.WriteLine("\nMatriz preenchida:");
        ExibirMatriz(matriz);

        // Exibe os elementos da diagonal principal.
        Console.WriteLine("\nElementos da diagonal principal:");
        ExibirDiagonalPrincipal(matriz);

        // Calcula e exibe a soma dos elementos abaixo da diagonal principal.
        int somaAbaixoDiagonal = SomaAbaixoDiagonalPrincipal(matriz);
        Console.WriteLine("\nSoma dos elementos abaixo da diagonal principal: " + somaAbaixoDiagonal);

    }
    public static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para preencher a matriz 4x4:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento[{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Procedimento para exibir o conteúdo da matriz.
    public static void ExibirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Procedimento para exibir os elementos da diagonal principal.
    public static void ExibirDiagonalPrincipal(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine($"Elemento[{i + 1},{i + 1}] = {matriz[i, i]}");
        }
    }

    // Função para calcular a soma dos elementos abaixo da diagonal principal.
    public static int SomaAbaixoDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 1; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
    }
}
