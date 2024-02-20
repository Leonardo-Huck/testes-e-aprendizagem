using System;

namespace EditorHtml
{

    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            Console.Write("Digite a opção: ");
            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }
        public static void DrawScreen()
        {
            Head("+", "-", 40);
            Body(40, 8);
            Head("+", "-", 40);

        }
        public static void Head(string inicial, string meio, int tamanho)
        {
            Console.Write(inicial);
            for (int i = 0; i <= tamanho; i++)
            {
                Console.Write(meio);
            }
            Console.WriteLine(inicial);
        }
        public static void Body(int tamanho, int linhas)
        {
            for (int linha = 0; linha <= linhas; linha++)
            {
                Console.Write("|");
                for (int coluna = 0; coluna <= tamanho; coluna++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("|");
            }
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(14, 2);
            Console.WriteLine("EDITOR HTML");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("1 - Novo Arquivo");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 8);
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: Viewer.Show(); break;
                case 0:
                    {
                        Console.Clear();
                        System.Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }
    }
}