using System;
namespace lista_04;
public class Atividade6
{
    public static void Questao()
    {
        Console.WriteLine("Digite o número de valores a serem verificados:");
        int N = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Digite um valor:");
            int valor = Convert.ToInt32(Console.ReadLine());

            if (EhPositivo(valor))
            {
                Console.WriteLine("O valor é positivo.");
            }
            else
            {
                Console.WriteLine("O valor é negativo.");
            }
        }
    }

    static bool EhPositivo(int valor)
    {
        return valor >= 0;
    }
}
