using System;

namespace Lista_01
{
    public class Atividade6
    {
        static void InverterValores()
        {
            Console.WriteLine("Informe o valor A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor B:");
            double b = double.Parse(Console.ReadLine());

            double aFinal = b;
            double bFinal = a;
            Console.WriteLine("O valor de A é: {0} e o valor de B é: {1}", aFinal, bFinal);
        }

        public static void Questao()
        {
            InverterValores();
        }
    }
}
