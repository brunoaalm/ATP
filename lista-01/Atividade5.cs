using System;

namespace Lista_01
{
    public class Atividade5
    {
        static void CalcularRendimento()
        {
            Console.WriteLine("Informe o valor da aplicação mensal constante:");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da taxa:");
            double i = double.Parse(Console.ReadLine()) / 100;
            Console.WriteLine("Informe o número de meses que terá a poupança programada:");
            double n = double.Parse(Console.ReadLine());

            double valormontante = p * (Math.Pow((1 + i), n) - 1) / i;
            double rendimento = valormontante - (p * n);
            Console.WriteLine("O rendimento da poupança é: R$ {0:0.00}", rendimento);
        }

        public static void Questao()
        {
            CalcularRendimento();
        }
    }
}
