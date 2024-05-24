using System;
namespace lista_04;
public class Atividade5
{
    public static void Questao()
    {
        Console.WriteLine("Digite dois números inteiros:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("O MDC é: " + CalcularMDC(a, b));
    }

    static int CalcularMDC(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}