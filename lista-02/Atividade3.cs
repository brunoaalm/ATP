using System;

namespace Lista_02
{
    public class Atividade3
    {
        static void ResolverEquacao()
        {
            Console.WriteLine("Digite o coeficiente a (diferente de zero):");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o coeficiente b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("O coeficiente a não pode ser zero para uma equação do primeiro grau.");
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("A raiz da equação é: " + x);
            }
        }

        public static void Questao()
        {
            ResolverEquacao();
        }
    }
}
