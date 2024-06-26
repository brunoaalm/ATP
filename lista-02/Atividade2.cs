using System;

namespace Lista_02
{
    public class Atividade2
    {
        static void SomarNumeros()
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num1 + num2;

            if (soma >= 10)
            {
                soma += 5;
            }
            else
            {
                soma += 7;
            }

            Console.WriteLine("O resultado final é: " + soma);
        }

        public static void Questao()
        {
            SomarNumeros();
        }
    }
}
