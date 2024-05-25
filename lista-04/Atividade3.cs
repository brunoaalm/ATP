using System;
namespace lista_04;
public class Atividade3
{
    public static void Questao()
    {
        Console.WriteLine("Digite o número de conjuntos:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite 3 valores:");
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int valor3 = Convert.ToInt32(Console.ReadLine());

            ExibirEmOrdemCrescente(valor1, valor2, valor3);
        }
    }

    static void ExibirEmOrdemCrescente(int valor1, int valor2, int valor3)
    {
        int[] valores = { valor1, valor2, valor3 };
        Array.Sort(valores);
        Console.WriteLine("Valores em ordem crescente: " + string.Join(", ", valores));
    }
}
