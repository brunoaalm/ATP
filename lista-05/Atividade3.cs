using System;
namespace lista_05;
public class Atividade3
{
	static int[] Retorno(int[] vetor)
	{
		int[] novo = new int[10];
		VetorPreenchido(vetor);
		int j = 0;
		for (int i = 0; i < 10; i++)
		{
			if (vetor[i] < 0)
			{
				novo[j++] = vetor[i];
                //Console.WriteLine(vetor[i]);
                //Console.WriteLine("Vetor novo: "+novo[i]);
            }
		}
		return novo;
	}
	static void VetorPreenchido(int[] vetor)
	{
		Random sorteio = new Random();
		for (int i = 0; i < 10; i++)
		{
			vetor[i] = sorteio.Next(-10, 10);
		}
	}
	static void Imprimir(int[] vetor)
	{
		for (int i = 0; i < 10; i++)
		{
			Console.WriteLine("Vetor: [{0}]",Retorno(vetor));
		}
	}
    public static void Questao()
    {
        Console.WriteLine("Faça um procedimento que preencha um vetor X de 10 elementos. A seguir faça uma função\r\nque receba um vetor preenchido, teste e copie todos os valores negativos deste vetor para um\r\nnovo vetor (sem deixar elementos vazios entre os valores copiados), retornando este vetor\r\ncomo resultado. Faça um procedimento que recebe e exibe o conteúdo de um vetor. Faça um\r\nprograma que faça as devidas declarações e acione os módulos para exemplificar o seu uso.");
        Console.WriteLine();

        int[] vetor = new int[10];
        Imprimir(vetor);
    }
}
