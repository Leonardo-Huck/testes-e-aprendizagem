using System;
using System.Diagnostics;

namespace Calculator;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("----- CALCULADORA COM FUNÇÕES -----");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Digite uma opção: ");
        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 5: System.Environment.Exit(0); break;
            default: Menu(); break;
        }
    }
    static void Soma()
    {
        Console.Clear();
        Console.WriteLine("Primeiro valor: ");
        float primeiroValor = float.Parse(Console.ReadLine());
        Console.WriteLine("Segundo valor: ");
        float segundoValor = float.Parse(Console.ReadLine());

        float resultado = primeiroValor + segundoValor;

        // Console.WriteLine($"O primeiro valor é {primeiroValor}");
        // Console.WriteLine($"O segundo valor é {segundoValor}");
        Console.WriteLine($"O resultado da soma é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Subtracao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float primeiroValor = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        float segundoValor = float.Parse(Console.ReadLine());

        float resultado = primeiroValor - segundoValor;

        Console.WriteLine($"O resultado da subtração é = {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Divisao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float primeiroValor = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        float segundoValor = float.Parse(Console.ReadLine());

        float resultado = primeiroValor / segundoValor;

        Console.WriteLine($"O resultado da divisão é: {resultado}");
        Console.ReadKey();
        Menu();
    }
    static void Multiplicacao()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro valor: ");
        float primeiroValor = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        float segundoValor = float.Parse(Console.ReadLine());

        float resultado = primeiroValor * segundoValor;

        Console.WriteLine($"O resultado da multiplicação é: {resultado}");
        Console.ReadKey();
        Menu();
    }
}
