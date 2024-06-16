using System;
namespace lista_05;
public class Atividade9
{
    public static void Questao()
    {
        // Cria duas matrizes 4x6 para armazenar os valores.
        int[,] matrizA = new int[4, 6];
        int[,] matrizB = new int[4, 6];

        // Chama o procedimento para preencher as matrizes A e B com valores fornecidos pelo usuário.
        PreencherMatrizes(matrizA, matrizB);

        // Exibe as matrizes A e B.
        Console.WriteLine("\nMatriz A:");
        ExibirMatriz(matrizA);

        Console.WriteLine("\nMatriz B:");
        ExibirMatriz(matrizB);

        // Chama a função para calcular a soma das matrizes A e B e exibe a matriz resultante.
        int[,] matrizS = SomaMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz S (Soma de A e B):");
        ExibirMatriz(matrizS);

        // Chama a função para calcular a diferença das matrizes A e B e exibe a matriz resultante.
        int[,] matrizD = DiferencaMatrizes(matrizA, matrizB);
        Console.WriteLine("\nMatriz D (Diferença de A e B):");
        ExibirMatriz(matrizD);

    }
    // Procedimento para preencher as matrizes 4x6 A e B com valores fornecidos pelo usuário.
    public static void PreencherMatrizes(int[,] matrizA, int[,] matrizB)
    {
        Console.WriteLine("Digite os valores para preencher a matriz A 4x6:");
        PreencherMatriz(matrizA);

        Console.WriteLine("Digite os valores para preencher a matriz B 4x6:");
        PreencherMatriz(matrizB);
    }

    // Procedimento para preencher uma matriz 4x6 com valores fornecidos pelo usuário.
    public static void PreencherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"Elemento[{i + 1},{j + 1}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    // Função para calcular a soma de duas matrizes 4x6.
    public static int[,] SomaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizS = new int[4, 6];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizS[i, j] = matrizA[i, j] + matrizB[i, j];
            }
        }
        return matrizS;
    }

    // Função para calcular a diferença de duas matrizes 4x6 (A - B).
    public static int[,] DiferencaMatrizes(int[,] matrizA, int[,] matrizB)
    {
        int[,] matrizD = new int[4, 6];
        for (int i = 0; i < matrizA.GetLength(0); i++)
        {
            for (int j = 0; j < matrizA.GetLength(1); j++)
            {
                matrizD[i, j] = matrizA[i, j] - matrizB[i, j];
            }
        }
        return matrizD;
    }

    // Procedimento para exibir o conteúdo de uma matriz 4x6.
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
