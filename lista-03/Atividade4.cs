using System;
namespace lista_03;
public class Atividade4
{
    public static void Questao()
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Número inválido. O número deve ser não negativo.");
        }
        else
        {
            long fatorial = 1;
            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }
            Console.WriteLine("Fatorial de " + n + " é: " + fatorial);
        }


    }
}