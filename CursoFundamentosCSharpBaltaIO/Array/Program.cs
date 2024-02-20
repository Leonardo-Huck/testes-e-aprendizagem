using System.Dynamic;

namespace Array;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        var funcionarios = new Funcionario[5];
        funcionarios[0] = new Funcionario() { Id = 2579, Nome = "André" };

        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine(funcionario.Id);
            Console.WriteLine(funcionario.Nome);
        }

        try
        {
            for (var i = 0; i <= 10; i++)
            {
                Console.WriteLine(funcionarios[i]);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.InnerException);
            Console.WriteLine(ex.Message);
            Console.WriteLine("Ops, algo deu errado");
        }
    public struct Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
