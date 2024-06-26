using System;

namespace Lista_01
{
    public class Atividade1
    {
        static void CalcularRetangulo()
        {
            Console.WriteLine("Informe:");
            Console.WriteLine("1- Perímetro:");
            Console.WriteLine("2- Área:");
            Console.WriteLine("3- Diagonal:");
            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base do retângulo: ");
            double baseret = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do retângulo: ");
            double alturaret = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    double perimetro = (baseret + alturaret) * 2;
                    Console.WriteLine("Perímetro: {0:0.00}", perimetro);
                    break;
                case 2:
                    double area = baseret * alturaret;
                    Console.WriteLine("Área: {0:0.00}", area);
                    break;
                case 3:
                    double diagonal = Math.Sqrt(Math.Pow(baseret, 2) + Math.Pow(alturaret, 2));
                    Console.WriteLine("Diagonal: {0:0.00}", diagonal);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public static void Questao()
        {
            CalcularRetangulo();
        }
    }
}
