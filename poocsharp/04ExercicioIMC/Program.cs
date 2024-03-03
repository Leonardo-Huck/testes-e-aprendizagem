namespace _04ExercicioIMC;

class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        Console.WriteLine("Digite seu peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua altura: ");
        double altura = double.Parse(Console.ReadLine());

        double imc = pessoa.IMC(peso, altura);
        
        string mensagemImc = pessoa.MensagemIMC(imc);
        Console.WriteLine($"Com o seu peso de {peso} e a sua altura de {altura}, seu IMC é de {(int)imc}\n logo {mensagemImc}");
    }
}
