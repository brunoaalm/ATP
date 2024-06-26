using System;

namespace Lista_01
{
    public class Atividade7
    {
        static void CalcularDiasSemAcidentes()
        {
            Console.WriteLine("Informe a quantidade de dias sem acidente na empresa:");
            int dias = int.Parse(Console.ReadLine());

            int ano = dias / 365;
            int mes = (dias % 365) / 30;
            int dia = (dias % 365) % 30;

            Console.WriteLine("A quantidade de dias sem acidente na empresa é: {0} ano(s), {1} mes(es) e {2} dia(s)", ano, mes, dia);
        }

        public static void Questao()
        {
            CalcularDiasSemAcidentes();
        }
    }
}
