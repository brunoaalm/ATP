using System;
namespace lista_04;
public class Atividade2
{
    public static void Questao()
    {
        {
            ColetarDados();
        }

        static void ColetarDados()
        {
            int numeroPessoas = 0;
            double salarioTotal = 0;
            int numeroFilhosTotal = 0;

            while (true)
            {
                Console.WriteLine("Digite o salário (ou -1 para sair):");
                double salario = Convert.ToDouble(Console.ReadLine());

                if (salario == -1) break;

                Console.WriteLine("Digite o número de filhos:");
                int numeroFilhos = Convert.ToInt32(Console.ReadLine());

                salarioTotal += salario;
                numeroFilhosTotal += numeroFilhos;
                numeroPessoas++;
            }

            if (numeroPessoas > 0)
            {
                Console.WriteLine("Média de salário: " + (salarioTotal / numeroPessoas));
                Console.WriteLine("Média de número de filhos: " + (numeroFilhosTotal / numeroPessoas));
            }
            else
            {
                Console.WriteLine("Nenhum dado foi inserido.");
            }
        }
    }
}
