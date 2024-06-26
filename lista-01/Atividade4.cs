using System;

namespace Lista_01
{
    public class Atividade4
    {
        static void CalcularDistancia()
        {
            Console.WriteLine("Informe o valor X do ponto 1:");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor Y do ponto 1:");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor X do ponto 2:");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor Y do ponto 2:");
            double y2 = double.Parse(Console.ReadLine());

            double distancia = Math.Sqrt(Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2));
            Console.WriteLine("A distância entre os pontos é: {0:0.0}", distancia);
        }

        public static void Questao()
        {
            CalcularDistancia();
        }
    }
}
