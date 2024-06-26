using System;
namespace Lista_06;
public class Atividade4
{
    static int ContarCaracter(string caminho, char caractere)
    {
        int contador = 0;
        using (StreamReader sr = new StreamReader(caminho))
        {
            string linha;
            while ((linha = sr.ReadLine()) != null)
            {
                foreach (char c in linha)
                {
                    if (c == caractere)
                    {
                        contador++;
                    }
                }
            }
        }
        return contador;
    }
    public static void Questao()
    {
        Console.WriteLine("Nome do arquivo:");
        string caminho = Console.ReadLine();
        int quantidade = ContarCaracter(caminho, 'a');
        Console.WriteLine($"O arquivo contém {quantidade} caracteres 'a'.");
    }
}
