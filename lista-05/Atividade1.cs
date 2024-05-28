using System;
namespace lista_05;
public class Atividade1
{
	public static void Questão()
	{
		int[] vetorN = new int[20];
		Random sorteio = new Random();
		for (int i = 0; i < 20; i++)
		{
			vetorN[i] = sorteio.Next()*20-0;
		}

		int menorM = vetorN[0];
		int posicaoP = 0;
		for (int i = 1; i < 20; i++)
		{
			if (vetorN[i] > menorM)
			{
				
				// averiguar
				posicaoP = i;

			}
		}



	}
}
