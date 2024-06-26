using System;
namespace Lista_02;
public class Program
{
    public static void VoltarAoMenu()
    {
        Console.WriteLine("\nAperte alguma tecla para voltar ao menu");
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {
        int questao;
        do
        {
            Console.WriteLine("Digite o número da questão que deseja executar (1-10):");
            if (int.TryParse(Console.ReadLine(), out questao))
            {
                switch (questao)
                {
                    case 1:
                        Atividade1.Questao();
                        break;
                    case 2:
                        Atividade2.Questao();
                        break;
                    case 3:
                        Atividade3.Questao();
                        break;
                    case 4:
                        Atividade4.Questao();
                        break;
                    case 5:
                        Atividade5.Questao();
                        break;
                    case 6:
                        Atividade6.Questao();
                        break;
                    case 7:
                        Atividade7.Questao();
                        break;
                    case 8:
                        Atividade8.Questao();
                        break;
                    case 9:
                        Atividade9.Questao();
                        break;
                    case 10:
                        Atividade10.Questao();
                        break;
                    default:
                        Console.WriteLine("Questão inválida.");
                        break;
                }
                VoltarAoMenu();
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite um número válido.");
            }
        } while (questao != 10); // Repete até que o usuário escolha sair
    }
}
  
