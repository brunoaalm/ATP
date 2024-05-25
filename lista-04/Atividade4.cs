using System;
namespace lista_04;
public class Atividade4
{
    public static void Questao()
    {
        while (true)
        {
            Console.WriteLine("Digite os comprimentos dos lados do triângulo (ou -1 para sair):");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x == -1) break;

            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            VerificarTriangulo(x, y, z);
        }
    }

    static void VerificarTriangulo(double x, double y, double z)
    {
        if (x + y > z && x + z > y && y + z > x)
        {
            if (x == y && y == z)
            {
                Console.WriteLine("Triângulo Equilátero.");
            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("Triângulo Isósceles.");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno.");
            }
        }
        else
        {
            Console.WriteLine("Não é um triângulo.");
        }
    }
}
