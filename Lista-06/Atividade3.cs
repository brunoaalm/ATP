using System;
namespace Lista_06;
public class Atividade3
{
    static string CodigoCesar(string texto, int deslocamento)
    {
        string resultado = "";
        foreach (char caractere in texto)
        {
            if (char.IsLetter(caractere))
            {
                char offset = char.IsUpper(caractere) ? 'A' : 'a';
                char novoCaractere = (char)((caractere + deslocamento - offset) % 26 + offset);
                resultado += novoCaractere;
            }
            else
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
        string fraseCodificada = CodigoCesar(frase, 3);
        Console.WriteLine($"Frase codificada: {fraseCodificada}");
    }
}
