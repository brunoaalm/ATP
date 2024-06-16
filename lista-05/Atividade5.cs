using System;
namespace lista_05;
public class Atividade5
{
    public static void Questao()
    {
        // Mensagem explicando a tarefa.
        Console.WriteLine("Tente adivinhar um dos três números sorteados entre 10 e 50.");

        // Chama a função para sortear 3 números.
        int[] numerosSorteados = SortearNumeros();

        // Procedimento que lê as tentativas do usuário até acertar um dos números sorteados.
        LerTentativas(numerosSorteados);

        // Informa ao usuário os números sorteados ao final.
        Console.WriteLine("Números sorteados: " + string.Join(", ", numerosSorteados));
    }
    public static int[] SortearNumeros()
    {
        Random random = new Random();
        int[] numeros = new int[3];

        // Sorteia 3 números distintos.
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(10, 51); // Gera números entre 10 e 50 (inclusive).
        }

        return numeros;
    }

    // Procedimento que lê as tentativas do usuário até acertar um dos números sorteados.
    public static void LerTentativas(int[] numerosSorteados)
    {
        bool acertou = false;

        // Continua solicitando tentativas até que o usuário acerte.
        while (!acertou)
        {
            Console.Write("Digite sua tentativa: ");
            int tentativa = int.Parse(Console.ReadLine());

            // Verifica se a tentativa do usuário está entre os números sorteados.
            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                if (tentativa == numerosSorteados[i])
                {
                    acertou = true;
                    Console.WriteLine("Parabéns! Você acertou o número: " + tentativa);
                    break; // Sai do loop assim que o número for acertado.
                }
            }

            if (!acertou)
            {
                Console.WriteLine("Tente novamente.");
            }
        }
    }
}
