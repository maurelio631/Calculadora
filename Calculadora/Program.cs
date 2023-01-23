using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soma();
            Subtracao();
            // Multiplicacao();
            // Divisao();

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

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            int primeiroValor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int segundoValor = Int32.Parse(Console.ReadLine());

            int subtracao = primeiroValor - segundoValor;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {subtracao}");


        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            int primeiroValor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int segundoValor = Int32.Parse(Console.ReadLine());

            int multiplicacao = primeiroValor * segundoValor;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {multiplicacao}");


        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            int primeiroValor = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            int segundoValor = Int32.Parse(Console.ReadLine());

            int divisao = primeiroValor - segundoValor;

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é: {divisao}");


        }
    }
}