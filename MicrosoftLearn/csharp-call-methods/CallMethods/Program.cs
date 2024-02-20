internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Random dice = new Random();
        int roll = dice.Next(1, 20);
        Console.WriteLine(roll);

        // versões sobrecarregadas do metodo WriteLine() 
        int number = 7;
        string text = "seven";
        //O primeiro método WriteLine() usa uma assinatura de método que define um parâmetro int
        Console.WriteLine(number);
        // O segundo método WriteLine() usa uma assinatura de método que define zero parâmetros de entrada
        Console.WriteLine();
        // O terceiro método WriteLine() usa uma assinatura de método que define um parâmetro string.
        Console.WriteLine(text);

        Random dice2 = new Random();
        int roll1 = dice2.Next(); // retorna 0 a 2,147,483,647 que é o limite de int
        int roll2 = dice2.Next(101); // 0 e 100
        int roll3 = dice2.Next(50, 101); //  50 e 100

        Console.WriteLine($"First roll: {roll1}");
        Console.WriteLine($"Second roll: {roll2}");
        Console.WriteLine($"Third roll: {roll3}");

        int firstValue = 500;
        int secondValue = 600;
        int largerValue = Math.Max(firstValue, secondValue); //sobrecarga de inteiros.

        Console.WriteLine(largerValue);
    }
}