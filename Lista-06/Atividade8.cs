using System;
namespace Lista_06;
public class Atividade8
{
    static void CalcularLocadora(int veiculos, double valorAluguel, string caminho)
    {
        double faturamentoMensal = (veiculos * valorAluguel) / 3;
        double faturamentoAnual = faturamentoMensal * 12;
        double multaMensal = (faturamentoMensal / 10) * 0.2;
        double manutencaoAnual = (veiculos * 0.02) * 600;

        Console.WriteLine($"Faturamento Anual: {faturamentoAnual}");
        Console.WriteLine($"Ganho com Multas Mensais: {multaMensal}");
        Console.WriteLine($"Gasto com Manutenção Anual: {manutencaoAnual}");

        using (StreamWriter sw = new StreamWriter(caminho))
        {
            sw.WriteLine($"Faturamento Anual: {faturamentoAnual}");
            sw.WriteLine($"Ganho com Multas Mensais: {multaMensal}");
            sw.WriteLine($"Gasto com Manutenção Anual: {manutencaoAnual}");
        }
    }
    public static void Questao()
    {
        Console.WriteLine("Quantidade de veículos:");
        int veiculos = int.Parse(Console.ReadLine());
        Console.WriteLine("Valor do aluguel:");
        double valorAluguel = double.Parse(Console.ReadLine());
        CalcularLocadora(veiculos, valorAluguel, "resultado.txt");
    }
}
