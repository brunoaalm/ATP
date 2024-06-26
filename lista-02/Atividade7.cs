using System;

namespace Lista_02
{
    public class Atividade7
    {
        static void CalcularY()
        {
            Console.Write("Digite o valor de x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y;

            if (x <= 1)
            {
                y = 1;
            }
            else if (x <= 2)
            {
                y = 2;
            }
            else if (x <= 3)
            {
                y = Math.Pow(x, 2); // x ao quadrado
            }
            else
            {
                y = Math.Pow(x, 3); // x ao cubo
            }

            Console.WriteLine($"O valor de y é: {y}");
        }

        public static void Questao()
        {
            CalcularY();
        }
    }
}
