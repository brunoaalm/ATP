using System;

namespace Lista_02
{
    public class Atividade9
    {
        static void IdentificarSimbolo()
        {
            Console.Write("Digite um símbolo (<, >, =): ");
            char simbolo = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (simbolo)
            {
                case '<':
                    Console.WriteLine("SINAL DE MENOR");
                    break;
                case '>':
                    Console.WriteLine("SINAL DE MAIOR");
                    break;
                case '=':
                    Console.WriteLine("SINAL DE IGUAL");
                    break;
                default:
                    Console.WriteLine("OUTRO SINAL");
                    break;
            }
        }

        public static void Questao()
        {
            IdentificarSimbolo();
        }
    }
}
