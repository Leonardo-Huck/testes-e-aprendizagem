using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("-----------");
            Start();
        }
        public static void Start()
        {
            var file = new StringBuilder();
            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("--------------------------");
            Console.WriteLine(" Deseja salvar o arquivo?");

            string resposta = "";
            bool respostaValida = false;

            while (!respostaValida)
            {
                Console.WriteLine("Digite 's' para sim ou 'n' para não:");
                resposta = Console.ReadLine();

                if (resposta == "s" || resposta == "n")
                {
                    respostaValida = true;
                }
            }

            if (resposta == "s")
            {
                Salvar(file);
                Menu.Show();
            }
            if (resposta == "n")
            {
                Menu.Show();
            }
        }
        public static void Salvar(StringBuilder html)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo? ");
            var path = Console.ReadLine();

            using (var arquivo = new StreamWriter(path))
            {
                arquivo.Write(html);
            }

            Console.WriteLine($"Arquivo {path} salvo com SUCESSO!");
            Console.ReadLine();
        }
    }
}