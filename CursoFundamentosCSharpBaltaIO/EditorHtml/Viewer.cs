using System;
using System.Text;
using System.Text.RegularExpressions;

namespace EditorHtml
{
    public static class Viewer
    {
        public static void Show()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("-----------");
            Console.WriteLine("Qual o caminho do arquivo?");
            var caminho = Console.ReadLine();
            var texto = " ";
            using (var file = new StreamReader(caminho))
            {
                string text = file.ReadToEnd();
                texto = text;
            }
            Replace(texto);
            Console.WriteLine("-----------");
            Console.ReadKey();
            Menu.Show();
        }
        public static void Replace(string text)
        {
            Console.WriteLine(" ");
            var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
            var words = text.Split(' ');

            for (var i = 0; i < words.Length; i++)
            {
                if (strong.IsMatch(words[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(
                        words[i].Substring(
                            words[i].IndexOf('>') + 1,
                            (
                                (words[i].LastIndexOf('<') - 1) -
                                words[i].IndexOf('>')
                            )
                        )

                    );
                    Console.Write(" ");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(words[i]);
                    Console.Write(" ");
                }
            }
            Console.WriteLine(" ");
        }
    }
}