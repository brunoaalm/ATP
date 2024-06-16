using System;
namespace lista_05;
public class Atividade6
{
    public static void Questao()
    {
        // Cria um vetor para armazenar as temperaturas de cada dia de outubro.
        double[] temperaturas = new double[31];

        // Chama o procedimento para preencher o vetor com as temperaturas fornecidas pelo usuário.
        PreencherTemperaturas(temperaturas);

        // Calcula e imprime a menor e a maior temperatura ocorrida.
        ImprimirMenorEMaiorTemperatura(temperaturas);

        // Calcula e imprime a temperatura média.
        double media = CalcularMedia(temperaturas);
        Console.WriteLine("Temperatura média: {0:F2}°C", media);

        // Calcula e imprime o número de dias com temperatura inferior à média.
        int diasAbaixoMedia = ContarDiasAbaixoMedia(temperaturas, media);
        Console.WriteLine("Número de dias com temperatura abaixo da média: " + diasAbaixoMedia);

    }
    public static void PreencherTemperaturas(double[] temperaturas)
    {
        Console.WriteLine("Digite as temperaturas de cada dia de outubro:");
        for (int i = 0; i < temperaturas.Length; i++)
        {
            Console.Write($"Temperatura do dia {i + 1}: ");
            temperaturas[i] = double.Parse(Console.ReadLine());
        }
    }

    // Procedimento para imprimir a menor e a maior temperatura ocorrida.
    public static void ImprimirMenorEMaiorTemperatura(double[] temperaturas)
    {
        double menor = temperaturas[0];
        double maior = temperaturas[0];

        // Encontra a menor e a maior temperatura.
        for (int i = 1; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < menor)
            {
                menor = temperaturas[i];
            }
            if (temperaturas[i] > maior)
            {
                maior = temperaturas[i];
            }
        }

        Console.WriteLine("Menor temperatura: {0:F2}°C", menor);
        Console.WriteLine("Maior temperatura: {0:F2}°C", maior);
    }

    // Função para calcular a temperatura média.
    public static double CalcularMedia(double[] temperaturas)
    {
        double soma = 0;

        // Soma todas as temperaturas.
        for (int i = 0; i < temperaturas.Length; i++)
        {
            soma += temperaturas[i];
        }

        // Calcula a média.
        return soma / temperaturas.Length;
    }

    // Função para contar o número de dias com temperatura abaixo da média.
    public static int ContarDiasAbaixoMedia(double[] temperaturas, double media)
    {
        int contador = 0;

        // Conta quantos dias têm temperatura abaixo da média.
        for (int i = 0; i < temperaturas.Length; i++)
        {
            if (temperaturas[i] < media)
            {
                contador++;
            }
        }

        return contador;
    }
}
