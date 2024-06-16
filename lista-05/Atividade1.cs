using System;
namespace lista_05;
public class Atividade1
{
	public static void Questao()
	{
        // Escreve uma mensagem na tela descrevendo a tarefa.
        Console.WriteLine("Faça um algoritmo que leia um vetor N[20]. A seguir, encontre o menor elemento do vetor\r\nN e a sua posição dentro do vetor, mostrando: “O menor elemento de N é”, M, “e sua posição\r\ndentro do vetor é:”,P.");
        Console.WriteLine();

        // Inicializa o vetor com 20 elementos pré-definidos.
        int[] vetorN = new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        // Inicializa 'menorM' com o primeiro valor do vetor e 'posicaoP' com 0.
        int menorM = vetorN[0];
        int posicaoP = 0;

        // Percorre o vetor a partir do segundo elemento para encontrar o menor valor e sua posição.
        for (int i = 1; i < vetorN.Length; i++)
        {
            // Se o elemento atual for menor que 'menorM', atualiza 'menorM' e 'posicaoP'.
            if (vetorN[i] < menorM)
            {
                menorM = vetorN[i];
                posicaoP = i;
            }
        }

        // Exibe cada posição e valor do vetor.
        foreach (int i in vetorN)
        {
            // Nota: Aqui há um erro, 'i' é o valor do elemento e não a posição. Ajustando para mostrar a posição corretamente:
            Console.WriteLine("A posição do vetor {0} é: {1}", Array.IndexOf(vetorN, i), i);
        }

        // Exibe o menor valor encontrado e sua posição.
        Console.WriteLine("O menor valor dentro do vetor é {0} e a sua posição do vetor é {1}", menorM, posicaoP);
    }
}
