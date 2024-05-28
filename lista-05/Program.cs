namespace lista_05;

internal class Program
{
    public static void VoltarAoMenu()
    {
        Console.WriteLine("\nAperte alguma tecla para voltar ao menu");
        Console.ReadKey();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o número da questão que deseja executar (1-10):");
        int questao = int.Parse(Console.ReadLine());

        switch (questao)
        {
            case 1:
                Atividade1.Questao();
                VoltarAoMenu();
                break;
            case 2:
                Atividade2.Questao();
                VoltarAoMenu();
                break;
            case 3:
                Atividade3.Questao();
                VoltarAoMenu();
                break;
            case 4:
                Atividade4.Questao();
                VoltarAoMenu();
                break;
            case 5:
                Atividade5.Questao();
                VoltarAoMenu();
                break;
            case 6:
                Atividade6.Questao();
                VoltarAoMenu();
                break;
            case 7:
                Atividade7.Questao();
                VoltarAoMenu();
                break;
            case 8:
                Atividade8.Questao();
                VoltarAoMenu();
                break;
            case 9:
                Atividade9.Questao();
                VoltarAoMenu();
                break;
            case 10:
                Atividade10.Questao();
                VoltarAoMenu();
                break;
            default:
                Console.WriteLine("Questão inválida.");
                break;
        }
    }
}
