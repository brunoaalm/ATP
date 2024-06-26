using System;

namespace Lista_02
{
    public class Atividade6
    {
        static void CalcularReceitaHotel()
        {
            const int totalApartamentos = 75;

            Console.Write("Digite o valor normal da diária: ");
            double diariaNormal = Convert.ToDouble(Console.ReadLine());

            double diariaPromocional = diariaNormal * 0.75;
            double receitaPromocional = diariaPromocional * (totalApartamentos * 0.80);
            double receitaNormal = diariaNormal * (totalApartamentos * 0.50);
            double diferencaReceitas = receitaPromocional - receitaNormal;

            Console.WriteLine($"O valor da diária promocional é: {diariaPromocional:C2}");
            Console.WriteLine($"O valor total arrecadado com 80% de ocupação e diária promocional é: {receitaPromocional:C2}");
            Console.WriteLine($"O valor total arrecadado com 50% de ocupação e diária normal é: {receitaNormal:C2}");
            Console.WriteLine($"A diferença entre os dois valores é: {diferencaReceitas:C2}");
        }

        public static void Questao()
        {
            CalcularReceitaHotel();
        }
    }
}
