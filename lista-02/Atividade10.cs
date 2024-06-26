using System;

namespace Lista_02
{
    public class Atividade10
    {
        static void CalcularMulta()
        {
            Console.Write("Digite a velocidade máxima permitida na avenida (km/h): ");
            int velocidadeMaxima = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a velocidade que o motorista estava dirigindo (km/h): ");
            int velocidadeMotorista = Convert.ToInt32(Console.ReadLine());

            int diferencaVelocidade = velocidadeMotorista - velocidadeMaxima;

            if (diferencaVelocidade <= 0)
            {
                Console.WriteLine("Motorista respeitou a lei.");
            }
            else
            {
                int valorMulta = 0;

                if (diferencaVelocidade <= 10)
                {
                    valorMulta = 50;
                }
                else if (diferencaVelocidade <= 30)
                {
                    valorMulta = 100;
                }
                else
                {
                    valorMulta = 200;
                }

                Console.WriteLine($"O motorista ultrapassou a velocidade permitida e a multa é de R$ {valorMulta}.");
            }
        }

        public static void Questao()
        {
            CalcularMulta();
        }
    }
}
