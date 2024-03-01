class Pessoa
{
    public void Apresentar()
    {
        Console.WriteLine("Olá!!");

    }

    public void Apresentar(string nome)
    {
        Console.WriteLine("Olá " + nome + "!!");
    }

    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine($"{nome} tem {idade} anos.");
    }
}