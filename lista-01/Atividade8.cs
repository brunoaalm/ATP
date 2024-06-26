using System;

namespace Lista_01
{
    public class Atividade8
    {
        static void CalcularDigitoVerificador()
        {
            Console.Write("Digite o número da conta corrente (3 dígitos): ");
            int conta = int.Parse(Console.ReadLine());

            if (conta < 100 || conta > 999)
            {
                Console.WriteLine("A conta corrente deve ter exatamente 3 dígitos.");
                return;
            }

            int u = conta % 10;
            int d = (conta / 10) % 10;
            int c = conta / 100;
            int inverso = u * 100 + d * 10 + c;
            int soma = conta + inverso;
            int somaMultiplicacoes = (soma / 1000) * 0 + (soma / 100 % 10) * 1 + (soma / 10 % 10) * 2 + (soma % 10) * 3;
            int digitoVerificador = somaMultiplicacoes % 10;

            Console.WriteLine("O dígito verificador é: {0}", digitoVerificador);
        }

        public static void Questao()
        {
            CalcularDigitoVerificador();
        }
    }
}
