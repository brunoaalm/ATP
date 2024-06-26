using System;
namespace Lista_06;
public class Atividade10
{
    public static void Questao()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        int quantidade = ContarEspacos(frase);
        Console.WriteLine($"A frase contém {quantidade} espaço(s) em branco.");
    }
    static int ContarEspacos(string texto)
    {
        int contador = 0;
        foreach (char caractere in texto)
        {
            if (char.IsWhiteSpace(caractere))
            {
                contador++;
            }
        }
        return contador;
    }


}

