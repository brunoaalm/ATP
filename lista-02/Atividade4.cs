using System;

namespace Lista_02
{
    public class Atividade4
    {
        static void CalcularIdade()
        {
            const int anoAtual = 2024;

            Console.Write("Digite o ano de seu nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Você já fez aniversário este ano? (S/N): ");
            bool fezAniversario = Console.ReadLine().Trim().ToUpper() == "S";

            int idade = anoAtual - anoNascimento - (fezAniversario ? 0 : 1);

            Console.WriteLine($"Sua idade é: {idade} anos.");

            if (idade >= 18)
            {
                Console.WriteLine("Você já tem idade para tirar a Carteira de Habilitação.");
            }
            else
            {
                Console.WriteLine("Você ainda não tem idade para tirar a Carteira de Habilitação.");
            }
        }

        public static void Questao()
        {
            CalcularIdade();
        }
    }
}
