using System;
namespace Lista_06;
public class Atividade6
{
    static void CalcularDivisores(int numero, string caminho)
    {
        int somaDivisores = 0;
        using (StreamWriter sw = new StreamWriter(caminho))
        {
            Console.WriteLine($"Divisores de {numero}:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.WriteLine(i);
                    somaDivisores += i;
                }
            }
            sw.WriteLine($"Soma dos divisores: {somaDivisores}");
        }
    }
    public static void Questao()
    {
        Console.WriteLine("Digite um número:");
        int numero = int.Parse(Console.ReadLine());
        CalcularDivisores(numero, "divisores.txt");
    }
}
