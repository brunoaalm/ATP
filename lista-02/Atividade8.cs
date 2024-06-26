using System;

namespace Lista_02
{
    public class Atividade8
    {
        static void CalcularNovoSalario()
        {
            Console.Write("Digite a opção de aumento (A, B ou C): ");
            char opcao = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            Console.Write("Digite o salário atual do funcionário: R$ ");
            double salarioAtual = Convert.ToDouble(Console.ReadLine());
            double novoSalario;

            switch (opcao)
            {
                case 'A':
                    novoSalario = salarioAtual * 1.08; // Aumento de 8%
                    break;
                case 'B':
                    novoSalario = salarioAtual * 1.11; // Aumento de 11%
                    break;
                case 'C':
                    novoSalario = salarioAtual + (salarioAtual <= 1000 ? 350 : 200); // Aumento fixo
                    break;
                default:
                    Console.WriteLine("Opção inválida. Não foi possível calcular o novo salário.");
                    return;
            }

            Console.WriteLine($"O novo salário, com base na opção '{opcao}', será de: R$ {novoSalario:F2}");
        }

        public static void Questao()
        {
            CalcularNovoSalario();
        }
    }
}
