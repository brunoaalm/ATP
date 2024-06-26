using System;

namespace Lista_06;

public class Atividade1
{
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

    public static void Questao()
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        int quantidade = ContarEspacos(frase);
        Console.WriteLine($"A frase contém {quantidade} espaço(s) em branco.");
    }
}
