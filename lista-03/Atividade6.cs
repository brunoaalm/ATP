using System;
namespace lista_03;
public class Atividade6
{
    public static void Questao()
    {
        double totalSalario = 0, maiorSalario = 0;
        int totalFilhos = 0, contador = 0, abaixo100 = 0;
        while (true)
        {
            Console.WriteLine("Digite o salário (um valor negativo para parar):");
            double salario = double.Parse(Console.ReadLine());
            if (salario < 0) break;

            Console.WriteLine("Digite o número de filhos:");
            int filhos = int.Parse(Console.ReadLine());

            totalSalario += salario;
            totalFilhos += filhos;
            contador++;

            if (salario > maiorSalario) maiorSalario = salario;
            if (salario <= 100) abaixo100++;

        }

        if (contador > 0)
        {
            double mediaSalario = totalSalario / contador;
            double mediaFilhos = (double)totalFilhos / contador;
            double percentualAbaixo100 = (abaixo100 * 100.0) / contador;

            Console.WriteLine("Média do salário da população: " + mediaSalario);
            Console.WriteLine("Média do número de filhos: " + mediaFilhos);
            Console.WriteLine("Maior salário: " + maiorSalario);
            Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percentualAbaixo100 + "%");
        }
        else
        {
            Console.WriteLine("Nenhum dado foi inserido.");
        }
    }
}