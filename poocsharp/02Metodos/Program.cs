namespace _02Metodos;

class Program
{
    static void Main(string[] args)
    {
        Pessoa obj = new Pessoa();
        obj.Apresentar("Jose", 30);
        obj.Apresentar();
        obj.Apresentar("Artur");
    }
}
