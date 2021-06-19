using System;

namespace KeyBoardTranslator
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Введите текст: (ESC для выхода, BackSpace удалить всё) ");
            ConsoleKey key = new ConsoleKey();
            do
            {
                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.A)
                    Console.Write('А');
                if (key == ConsoleKey.B)
                    Console.Write('Б');
                if (key == ConsoleKey.C)
                    Console.Write('Ц');
                if (key == ConsoleKey.D)
                    Console.Write('Д');
                if (key == ConsoleKey.E)
                    Console.Write('Е');
                if (key == ConsoleKey.F)
                    Console.Write('Ф');
                if (key == ConsoleKey.G)
                    Console.Write('Г');
                if (key == ConsoleKey.I)
                    Console.Write('И');
                if (key == ConsoleKey.J)
                    Console.Write('Ж');
                if (key == ConsoleKey.K)
                    Console.Write('К');
                if (key == ConsoleKey.L)
                    Console.Write('Л');
                if (key == ConsoleKey.M)
                    Console.Write('М');
                if (key == ConsoleKey.N)
                    Console.Write('Н');
                if (key == ConsoleKey.O)
                    Console.Write('О');
                if (key == ConsoleKey.P)
                    Console.Write('П');
                if (key == ConsoleKey.R)
                    Console.Write('Р');
                if (key == ConsoleKey.S)
                    Console.Write('С');
                if (key == ConsoleKey.T)
                    Console.Write('Т');
                if (key == ConsoleKey.U)
                    Console.Write('У');
                if (key == ConsoleKey.Q)
                    Console.Write('К');
                if (key == ConsoleKey.H)
                    Console.Write('Х');
                if (key == ConsoleKey.V)
                    Console.Write('В');
                if (key == ConsoleKey.X)
                    Console.Write('Х');
                if (key == ConsoleKey.Z)
                    Console.Write('З');
                if (key == ConsoleKey.Y)
                    Console.Write('Й');
                if (key == ConsoleKey.W)
                    Console.Write('Ш');
                if (key == ConsoleKey.OemPeriod) 
                    Console.Write('.');
                if (key == ConsoleKey.OemComma)
                    Console.Write(',');
                if (key == ConsoleKey.Spacebar)
                    Console.Write(' ');
                if (key == ConsoleKey.Oem2)
                    Console.Write('?');
                if (key == ConsoleKey.Oem7)
                    Console.Write('Ь');
                if (key == ConsoleKey.Enter)
                    Console.WriteLine();
                if (key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                    Console.WriteLine("Введите текст: (ESC для выхода, BackSpace удалить всё) ");
                }
                /*else
                    Console.Write(key);*/

            } while (key != ConsoleKey.Escape);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВы успешно вышли с программы");
            Console.ForegroundColor = ConsoleColor.White;
            return 0;
        }
    }
}
