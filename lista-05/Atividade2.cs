using System;
namespace lista_05;
public class Atividade2
{

	public void Preencher()
	{
		Random n = new Random(11);
		for (int i = 0; i < 10; i++)
		{
			vt[n] = n.NextInt64();
		}
	}

	public void Imprimir(int vetor[10])
	{
		for (int i = 0; i < 10; i++)
			Console.WriteLine("Vet[" + i"]=" + vetor[i]);
	}

	public double CalculaMedia(int vetor[10])
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
	public static void Questao()
	{
		int[] vetor = new int[10];
		Preencher(vetor);
		Imprimir(vetor);

	}
}
