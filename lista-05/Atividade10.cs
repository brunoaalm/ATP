using System;
namespace lista_05;
public class Atividade10
{
    public static void Questao()
    {
        // Cria uma matriz 10x10 para armazenar os valores.
        int[,] matriz = new int[10, 10];

        // Chama o procedimento para preencher a matriz com valores fornecidos pelo usuário.
        PreencherMatriz(matriz);

        // Exibe a matriz preenchida.
        Console.WriteLine("\nMatriz preenchida:");
        ExibirMatriz(matriz);

        // Realiza a troca da linha 2 com a linha 8 e exibe a matriz resultante.
        TrocarLinhas(matriz, 1, 7);
        Console.WriteLine("\nMatriz após trocar a linha 2 com a linha 8:");
        ExibirMatriz(matriz);

        // Realiza a troca da coluna 4 com a coluna 10 e exibe a matriz resultante.
        TrocarColunas(matriz, 3, 9);
        Console.WriteLine("\nMatriz após trocar a coluna 4 com a coluna 10:");
        ExibirMatriz(matriz);

        // Realiza a troca da diagonal principal com a diagonal secundária e exibe a matriz resultante.
        TrocarDiagonais(matriz);
        Console.WriteLine("\nMatriz após trocar a diagonal principal com a diagonal secundária:");
        ExibirMatriz(matriz);

        // Realiza a troca da linha 5 com a coluna 10 e exibe a matriz resultante.
        TrocarLinhaComColuna(matriz, 4, 9);
        Console.WriteLine("\nMatriz após trocar a linha 5 com a coluna 10:");
        ExibirMatriz(matriz);
    }
    // Procedimento para preencher a matriz 10x10 com valores fornecidos pelo usuário.
    public static void PreencherMatriz(int[,] matriz)
    {
        Console.WriteLine("Digite os valores para preencher a matriz 10x10:");
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento[{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Procedimento para trocar duas linhas em uma matriz.
    public static void TrocarLinhas(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }
    }

    // Procedimento para trocar duas colunas em uma matriz.
    public static void TrocarColunas(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[i, coluna1];
            matriz[i, coluna1] = matriz[i, coluna2];
            matriz[i, coluna2] = temp;
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária.
    public static void TrocarDiagonais(int[,] matriz)
    {
        int n = matriz.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, n - 1 - i];
            matriz[i, n - 1 - i] = temp;
        }
    }

    // Procedimento para trocar uma linha com uma coluna em uma matriz.
    public static void TrocarLinhaComColuna(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna];
            matriz[i, coluna] = temp;
        }
    }

    // Procedimento para exibir o conteúdo de uma matriz 10x10.
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
