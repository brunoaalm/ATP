using System;

namespace Lista_01
{
    public class Atividade2
    {
        static void CalcularHipotenusa()
        {
            Console.WriteLine("Informe o cateto oposto:");
            double catetoop = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o cateto adjacente:");
            double catetoadj = double.Parse(Console.ReadLine());

            double hipotenusa = Math.Sqrt(Math.Pow(catetoop, 2) + Math.Pow(catetoadj, 2));
            Console.WriteLine("Hipotenusa: {0:0.00}", hipotenusa);
        }

        public static void Questao()
        {
            CalcularHipotenusa();
        }
    }
}
