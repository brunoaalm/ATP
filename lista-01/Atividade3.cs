using System;

namespace Lista_01
{
    public class Atividade3
    {
        static void CalcularKilowatt()
        {
            Console.WriteLine("Informe o valor do salário mínimo atualmente:");
            double salariomin = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de kilowatt de energia gasta:");
            double kilo = double.Parse(Console.ReadLine());

            double valorfinal = (salariomin / 7) * kilo / 100;
            double valorkilo = salariomin / 700;
            double desconto = valorfinal - ((valorfinal / 100) * 10);

            Console.WriteLine("Valor do kilo: R$ {0:0.00}", valorkilo);
            Console.WriteLine("Valor a ser pago: R$ {0:0.00}", valorfinal);
            Console.WriteLine("Valor a ser pago com desconto: R$ {0:0.00}", desconto);
        }

        public static void Questao()
        {
            CalcularKilowatt();
        }
    }
}
