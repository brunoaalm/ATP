using System;
namespace lista_05;
public class Atividade7
{
    public static void Questao()
    {
        // Cria uma matriz 5x5 para armazenar os valores.
        int[,] matriz = new int[5, 5];

        // Chama o procedimento para preencher a matriz com valores fornecidos pelo usuário.
        PreencherMatriz(matriz);

        // Exibe a matriz.
        Console.WriteLine("Matriz preenchida:");
        ExibirMatriz(matriz);

        // Chama as funções para calcular as somas e exibe os resultados.
        Console.WriteLine("Soma da linha 4: " + SomaLinha4(matriz));
        Console.WriteLine("Soma da coluna 2: " + SomaColuna2(matriz));
        Console.WriteLine("Soma da diagonal principal: " + SomaDiagonalPrincipal(matriz));
        Console.WriteLine("Soma da diagonal secundária: " + SomaDiagonalSecundaria(matriz));
        Console.WriteLine("Soma de todos os elementos: " + SomaTodosElementos(matriz));

    }
    public static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para preencher a matriz 5x5:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento[{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para calcular a soma da linha 4.
    public static int SomaLinha4(int[,] matriz)
    {
        int soma = 0;
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            soma += matriz[3, j]; // Linha 4 é o índice 3.
        }
        return soma;
    }

    // Função para calcular a soma da coluna 2.
    public static int SomaColuna2(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, 1]; // Coluna 2 é o índice 1.
        }
        return soma;
    }

    // Função para calcular a soma da diagonal principal.
    public static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            soma += matriz[i, i]; // Índices iguais para diagonal principal.
        }
        return soma;
    }

    // Função para calcular a soma da diagonal secundária.
    public static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        int n = matriz.GetLength(0); // Tamanho da matriz.
        for (int i = 0; i < n; i++)
        {
            soma += matriz[i, n - 1 - i]; // Índices invertidos para diagonal secundária.
        }
        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz.
    public static int SomaTodosElementos(int[,] matriz)
    {
        int soma = 0;
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                soma += matriz[i, j];
            }
        }
        return soma;
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
}
