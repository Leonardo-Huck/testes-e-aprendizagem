using System.Globalization;

namespace Datas;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //var data = new DateTime(); //01/01/0001 00:00:00
        // var data = new DateTime(2024, 3, 24);
        // Console.WriteLine(data);
        // var agora = DateTime.Now; //Data e hora de agora ex: 13/02/2024 14:24:48
        // Console.WriteLine(agora);
        // Console.WriteLine(agora.Year);
        // Console.WriteLine(agora.Day);
        // Console.WriteLine(agora.Month);
        // Console.WriteLine(agora.DayOfYear);
        // Console.WriteLine(agora.TimeOfDay);

        // var data = DateTime.Now;
        // var formatada = String.Format("{0: dd/MM/yyyy}", data);
        // Console.WriteLine(formatada);

        //Para adicionar dias ou qualquer outra adição ou subtração,
        //Utilizar o metodo data.AddDays(4); ou data.AddMonths(1)

        var br = new CultureInfo("pt-BR");
        Console.WriteLine(DateTime.Now.ToString("D", br));

        var hora = new TimeSpan(12, 10, 45);
        Console.WriteLine(hora);

        decimal valor = 10.25m;

        Console.WriteLine(valor.ToString("C", br));

    }
}
