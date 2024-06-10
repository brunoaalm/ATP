using System;
namespace lista_05;
public class Atividade3
{
	static int Retorno(int[] vetor)
	{
		int[] novo = new int[10];
		VetorPreenchido(vetor);
		for (int i = 0; i < 10; i++)
		{
            if (vetor[i] < 0)
			{
				vetor[i] += novo[i];
				//Console.WriteLine("Vetor novo: "+novo[i]);
			}
		}
		
        return novo[i];
	}
	static void VetorPreenchido(int[] vetor)
	{
		Random sorteio = new Random();
		for (int i = 0; i < 10; i++)
		{
			vetor[i] = sorteio.Next(-10,10);
			Console.WriteLine("Vetor [{0}]: {1}", i,vetor[i]);
		}

	}
	public static void Questao()
	{
		Console.WriteLine("Faça um procedimento que preencha um vetor X de 10 elementos. A seguir faça uma função\r\nque receba um vetor preenchido, teste e copie todos os valores negativos deste vetor para um\r\nnovo vetor (sem deixar elementos vazios entre os valores copiados), retornando este vetor\r\ncomo resultado. Faça um procedimento que recebe e exibe o conteúdo de um vetor. Faça um\r\nprograma que faça as devidas declarações e acione os módulos para exemplificar o seu uso.");
		Console.WriteLine();

		int[] vetor = new int[10];
		Retorno(vetor);
	}
}
