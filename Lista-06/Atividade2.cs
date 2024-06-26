using System;
namespace Lista_06;
public class Atividade2
{
    static string RemoverVogais(string texto)
    {
        string resultado = "";
        foreach (char caractere in texto)
        {
            if (!"aeiouAEIOU".Contains(caractere))
            {
                resultado += caractere;
            }
        }
        return resultado;
    }
    public static void Questao()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        string fraseSemVogais = RemoverVogais(frase);
        Console.WriteLine($"Frase sem vogais: {fraseSemVogais}");
    }
}
