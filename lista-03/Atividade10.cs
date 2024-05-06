using System;
namespace lista_03;
public class Atividade10
{
    public static void Questao()
    {
        double totalCompra = 0, totalVenda = 0, lucroTotal = 0;
        int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;

        while (true)
        {
            Console.WriteLine("Informe o preço de compra da mercadoria (ou digite 0 para encerrar):");
            double compra = double.Parse(Console.ReadLine());
            if (compra == 0) break;

            Console.WriteLine("Informe o preço de venda da mercadoria:");
            double venda = double.Parse(Console.ReadLine());

            double lucro = venda - compra;
            double percentualLucro = (lucro / compra) * 100;

            totalCompra += compra;
            totalVenda += venda;
            lucroTotal += lucro;

            if (percentualLucro < 10) lucroMenor10++;
            else if (percentualLucro <= 20) lucroEntre10e20++;
            else lucroMaior20++;
        }

        Console.WriteLine("Mercadorias com lucro < 10%: " + lucroMenor10);
        Console.WriteLine("Mercadorias com 10% <= lucro <= 20%: " + lucroEntre10e20);
        Console.WriteLine("Mercadorias com lucro > 20%: " + lucroMaior20);
        Console.WriteLine("Valor total de compra: " + totalCompra);
        Console.WriteLine("Valor total de venda: " + totalVenda);
        Console.WriteLine("Lucro total: " + lucroTotal);
    }
}