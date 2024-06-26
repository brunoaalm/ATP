using System;

namespace Lista_02
{
    public class Atividade1
    {
        static void CompararNumeros()
        {
            Console.WriteLine("Digite o primeiro número:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("O maior número é: {0}", num1);
            }
            else if (num2 > num1)
            {
                Console.WriteLine("O maior número é: {0}", num2);
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }

        public static void Questao()
        {
            CompararNumeros();
        }
    }
}
