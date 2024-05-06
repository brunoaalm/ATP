using System;
namespace lista_03;
public class Atividade11
{
    public static void Questao()
    {
        int[] votos = new int[7]; // Índices 1-4 para candidatos, 5 para nulos, 6 para brancos

        while (true)
        {
            Console.WriteLine("Digite o código do voto (0 para encerrar):");
            int voto = int.Parse(Console.ReadLine());
            if (voto == 0) break;

            if (voto >= 1 && voto <= 6) votos[voto]++;
            else Console.WriteLine("Voto inválido.");
        }

        Console.WriteLine("Total de votos para cada candidato:");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Candidato " + i + ": " + votos[i]);
        }
        Console.WriteLine("Votos nulos: " + votos[5]);
        Console.WriteLine("Votos em branco: " + votos[6]);
    }
}