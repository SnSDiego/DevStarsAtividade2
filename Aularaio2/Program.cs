using System;

namespace Aularaio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da\n" +
                " área deste círculo com quatro casas decimais conforme exemplos.\n" +
                " Fórmula da área: area = π.raio²\n" +
                " Considere o valor de π = 3.14159");
            Console.WriteLine();
            Console.WriteLine("Digite um numero para callcular o raio do circulo");
            Console.WriteLine();
            double pi = 3.14159;
            double raio1 = 2.00;
            double raio2 = 100.64;
            double raio3 = 150.00;
            double area1 = (raio1 * raio1) * pi;
            Console.WriteLine("(A) Arear de numero 1 e " + area1.ToString("f4"));
            double area2 = (raio2 * raio2) * pi;
            Console.WriteLine("(A) Arear de numero 2 e " + area2.ToString("f4"));
            double area3 = (raio3 * raio3) * pi;
            Console.WriteLine("(A) Arear de numero 3 e " + area3.ToString("f4"));

        }
    }
}
