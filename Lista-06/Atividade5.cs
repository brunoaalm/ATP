using System;
namespace Lista_06;
public class Atividade5
{
    public static void Questao()
    {
        Console.WriteLine("Nome do arquivo:");
        string caminho = Console.ReadLine();
        int linhas = 0;
        using (StreamReader sr = new StreamReader(caminho))
        {
            string linha;
            while ((linha = sr.ReadLine()) != null)
            {
                Console.WriteLine(linha);
                linhas++;
            }
        }
        Console.WriteLine($"O arquivo contém {linhas} linha(s).");
    }
}
