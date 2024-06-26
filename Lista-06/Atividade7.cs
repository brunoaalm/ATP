using System;
namespace Lista_06;
public class Atividade7
{
    static void InserirLetras(int n, string caminho)
    {
        string letras = "";
        using (StreamWriter sw = new StreamWriter(caminho))
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite uma letra: ");
                char letra = char.Parse(Console.ReadLine());
                sw.Write(letra);
                letras += letra;
            }
        }
        int vogais = 0;
        foreach (char c in letras)
        {
            if ("aeiouAEIOU".Contains(c))
                vogais++;
        }
        Console.WriteLine($"Quantidade de vogais: {vogais}");
    }
    public static void Questao()
    {
        Console.WriteLine("Quantas letras deseja inserir?");
        int n = int.Parse(Console.ReadLine());
        InserirLetras(n, "letras.txt");
    }
}
