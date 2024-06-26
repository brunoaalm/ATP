using System;
namespace Lista_06;
public class Atividade9
{
    static void InserirDadosAlunos()
    {
        using (StreamWriter sw = new StreamWriter("alunos.txt", true))
        {
            Console.Write("Digite a matrícula: ");
            string matricula = Console.ReadLine();
            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();
            sw.WriteLine($"{matricula},{telefone}");
        }
    }

    static void LerDadosAlunos()
    {
        using (StreamReader sr = new StreamReader("alunos.txt"))
        {
            string linha;
            while ((linha = sr.ReadLine()) != null)
            {
                string[] dados = linha.Split(',');
                Console.WriteLine($"Matrícula: {dados[0]}, Telefone: {dados[1]}");
            }
        }
    }

    public static void Questao()
    {
        while (true)
        {
            Console.WriteLine("1 - Inserir dados de alunos");
            Console.WriteLine("2 - Ler dados de alunos");
            Console.WriteLine("3 - Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    InserirDadosAlunos();
                    break;
                case 2:
                    LerDadosAlunos();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
