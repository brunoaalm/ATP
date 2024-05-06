using System;
namespace lista_03;
public class Atividade3
{
    public static void Questao()
    {
        int countDiv3And9 = 0, countDiv2 = 0, countDiv5 = 0;
        Console.WriteLine("Digite dez números:");
        for (int i = 0; i < 10; i++)
        {
            int number = int.Parse(Console.ReadLine());

            bool div3And9 = (number % 3 == 0) && (number % 9 == 0);
            bool div2 = number % 2 == 0;
            bool div5 = number % 5 == 0;

            if (div3And9) countDiv3And9++;
            if (div2) countDiv2++;
            if (div5) countDiv5++;

            if (!div3And9 && !div2 && !div5)
            {
                Console.WriteLine("Número não é divisível pelos valores");
            }
        }

        Console.WriteLine("Divisíveis por 3 e 9: " + countDiv3And9);
        Console.WriteLine("Divisíveis por 2: " + countDiv2);
        Console.WriteLine("Divisíveis por 5: " + countDiv5);
    }
}
