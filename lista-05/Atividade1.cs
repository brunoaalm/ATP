using System;
namespace lista_05;
public class Atividade1
{
	public static void Questao()
	{
		int[] vetorN = new int[20] {1, 2, 3, 4, 5, 6, 8, 9 ,10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21};
		

		int menorM = vetorN[0];
		int posicaoP = 0;
		for (int i = 1; i < 20; i++)
		{
			if (vetorN[i] < menorM)
			{

				menorM = vetorN[i];
				posicaoP = i;
			}

		}
		foreach (int i in vetorN)
		{
			Console.WriteLine("A posição do vetor {0} é: {1}",i-1, i);
		}
		Console.WriteLine("O menor valor dentro do vetor é {0} e a sua posição do vetor é {1}", menorM, posicaoP);




    }
}
