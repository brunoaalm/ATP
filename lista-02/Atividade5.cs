using System;

namespace Lista_02
{
    public class Atividade5
    {
        static void ClassificarNota()
        {
            Console.Write("Digite uma nota entre 0 e 10: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Nota inválida");
            }
            else if (nota >= 8)
            {
                Console.WriteLine("Ótimo");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Bom");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Insatisfatório");
            }
        }

        public static void Questao()
        {
            ClassificarNota();
        }
    }
}
