using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();

        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            int primeiroValor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int segundoValor = Int32.Parse(Console.ReadLine());

            int soma = primeiroValor + segundoValor;

            Console.WriteLine("");

            // Console.WriteLine("O resultado da soma é: " + soma);
            Console.WriteLine($"O resultado da soma é: {soma}");
            // Console.WriteLine($"O resultado da soma é: {primeiroValor + segundoValor}");
        }
    }
}