using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace KeyBoardTranslator
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.SetWindowSize(100, 28);

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"" +
            $"       _   __          ______                     _   _____                   _       _       \n" +
            $"      | | / /          | ___ \\                   | | |_   _|                 | |     | |      \n" +
            $"      | |/ /  ___ _   _| |_/ / ___   __ _ _ __ __| |   | |_ __ __ _ _ __  ___| | __ _| |_ ___ \n" +
            $"      |    \\ / _ \\ | | | ___ \\/ _ \\ / _` | '__/ _` |   | | '__/ _` | '_ \\/ __| |/ _` | __/ _ \\\n" +
            $"      | |\\  \\  __/ |_| | |_/ / (_) | (_| | | | (_| |   | | | | (_| | | | \\__ \\ | (_| | ||  __/\n" +
            $"      \\_| \\_/\\___|\\__, \\____/ \\___/ \\__,_|_|  \\__,_|   \\_/_|  \\__,_|_| |_|___/_|\\__,_|\\__\\___|\n" +
            $"                   __/ |                                                                      \n" +
            $"                  |___/                                                                       \n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(" .................................................................................................");
            Console.WriteLine(" .  A = А,  B = Б,  C = Ц,  D = Д, E = Е,  F = Ф,  G = Г,  H = Х,  I = И,  J = Ж, YA = Я, ~I = Ы .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .  K = К,  L = Л,  M = М,  N = Н, O = О,  P = П,  Q = К,  R = Р,  S = С,  T = T, ~W = Щ, ~E = Э .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .  U = У,  V = В,  W = Ш,  X = Х, Y = Й,  Z = З, CH = Ч, SH = Ш, YU = Ю, YO = Ё,  ; = Ь, ~; = Ъ .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .  (ESC выход, BackSpace удалить букву, Enter новая строка, Delete удалить всё, Tab сохранить)  .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .                                     Введите текст:                                            .");
            Console.WriteLine(" .................................................................................................");
            Console.ForegroundColor = ConsoleColor.White;
            ConsoleKey key = new ConsoleKey();
            string word = "";
            List<string> list = new List<string>();
            Console.Write(" ");
            START:
            key = Console.ReadKey(true).Key;
            ENTER:
            if (key == ConsoleKey.D0 || key == ConsoleKey.NumPad0)
            {
                word += '0';
            }
            if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
            {
                word += '1';
            }
            if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
            {
                word += '2';
            }
            if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
            {
                word += '3';
            }
            if (key == ConsoleKey.D4 || key == ConsoleKey.NumPad4)
            {
                word += '4';
            }
            if (key == ConsoleKey.D5 || key == ConsoleKey.NumPad5)
            {
                word += '5';
            }
            if (key == ConsoleKey.D6 || key == ConsoleKey.NumPad6)
            {
                word += '6';
            }
            if (key == ConsoleKey.D7 || key == ConsoleKey.NumPad7)
            {
                word += '7';
            }
            if (key == ConsoleKey.D8 || key == ConsoleKey.NumPad8)
            {
                word += '8';
            }
            if (key == ConsoleKey.D9 || key == ConsoleKey.NumPad9)
            {
                word += '9';
            }
            if (key == ConsoleKey.A)
            {
                if (word.Length != 0 && word[word.Length - 1] == 'Й')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Я';
                }
                else word += 'А';
            }
            if (key == ConsoleKey.B)
                word += 'Б';
            if (key == ConsoleKey.C)
                word += 'Ц';
            if (key == ConsoleKey.D)
                word += 'Д';
            if (key == ConsoleKey.E)
            {
                if (word.Length != 0 && word[word.Length - 1] == '~')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Э';
                }
                else word += 'Е';
            }
            
            if (key == ConsoleKey.F)
                word += 'Ф';
            if (key == ConsoleKey.G)
                word += 'Г';
            if (key == ConsoleKey.I)
            {
                if (word.Length != 0 && word[word.Length - 1] == '~')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Ы';
                }
                else word += 'И';
            }
            
            if (key == ConsoleKey.J)
                word += 'Ж';
            if (key == ConsoleKey.K)
                word += 'К';
            if (key == ConsoleKey.L)
                word += 'Л';
            if (key == ConsoleKey.M)
                word += 'М';
            if (key == ConsoleKey.N)
                word += 'Н';
            if (key == ConsoleKey.O)
            {
                if (word.Length != 0 && word[word.Length - 1] == 'Й')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Ё';
                }
                else word += 'О';
            }
            if (key == ConsoleKey.P)
                word += 'П';
            if (key == ConsoleKey.R)
                word += 'Р';
            if (key == ConsoleKey.S)
                word += 'С';
            if (key == ConsoleKey.T)
                word += 'Т';
            if (key == ConsoleKey.U)
            {
                if (word.Length != 0 && word[word.Length - 1] == 'Й')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Ю';
                }
                else word += 'У';
            }
                
            if (key == ConsoleKey.Q)
                word += 'К';
            if (key == ConsoleKey.H)
            {
                if (word.Length != 0 && word[word.Length-1] == 'Ц')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Ч';
                }
                else if (word.Length != 0 && word[word.Length - 1] == 'С')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Ш';
                }
                else word += 'Х';
            }
            if (key == ConsoleKey.V)
                word += 'В';
            if (key == ConsoleKey.X)
                word += 'Х';
            if (key == ConsoleKey.Z)
                word += 'З';
            if (key == ConsoleKey.Y)
                word += 'Й';
            if (key == ConsoleKey.W)
            {
                if (word.Length != 0 && word[word.Length - 1] == '~')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Щ';
                }
                else word += 'Ш';
            }
            
            if (key == ConsoleKey.OemPeriod || key == ConsoleKey.Decimal) 
                word += '.';
            if (key == ConsoleKey.OemComma)
                word += ',';
            if (key == ConsoleKey.Spacebar)
                word += ' ';
            if (key == ConsoleKey.Oem2)
                word += '?';
            if (key == ConsoleKey.Oem1)
            {
                if (word.Length != 0 && word[word.Length - 1] == '~')
                {
                    word = word.Substring(0, word.Length - 1);
                    word += 'Ъ';
                }
                else word += 'Ь';
            }
            
            if (key == ConsoleKey.Oem3)
                word += '~';
            if (key == ConsoleKey.Backspace)
            {
                if (word != "")
                    word = word.Substring(0, word.Length-1);
            }
            if (key == ConsoleKey.Enter)
            {
                if (word != "")
                {
                    list.Add(word);
                    word = "";
                    goto ENTER;
                }
            }
            if (key == ConsoleKey.Tab)
            {
                if (word != "" || list.Count != 0)
                {
                    File.WriteAllLines("Result.txt", list);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Файл успешно сохранён!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пусто...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                }
            }
            if (key == ConsoleKey.Delete)
            {
                Console.Clear();
                word = "";
                list.RemoveRange(0, list.Count);
            }
            if (key == ConsoleKey.Escape)
            {
                goto END;
            }
            if (key == ConsoleKey.OemMinus || key == ConsoleKey.Subtract)
            {
                word += '-';
            }
            /*else
                Console.Write(key);*/
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"" +
            $"       _   __          ______                     _   _____                   _       _       \n" +
            $"      | | / /          | ___ \\                   | | |_   _|                 | |     | |      \n" +
            $"      | |/ /  ___ _   _| |_/ / ___   __ _ _ __ __| |   | |_ __ __ _ _ __  ___| | __ _| |_ ___ \n" +
            $"      |    \\ / _ \\ | | | ___ \\/ _ \\ / _` | '__/ _` |   | | '__/ _` | '_ \\/ __| |/ _` | __/ _ \\\n" +
            $"      | |\\  \\  __/ |_| | |_/ / (_) | (_| | | | (_| |   | | | | (_| | | | \\__ \\ | (_| | ||  __/\n" +
            $"      \\_| \\_/\\___|\\__, \\____/ \\___/ \\__,_|_|  \\__,_|   \\_/_|  \\__,_|_| |_|___/_|\\__,_|\\__\\___|\n" +
            $"                   __/ |                                                                      \n" +
            $"                  |___/                                                                       \n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(" .................................................................................................");
            Console.WriteLine(" .  A = А,  B = Б,  C = Ц,  D = Д, E = Е,  F = Ф,  G = Г,  H = Х,  I = И,  J = Ж, YA = Я, ~I = Ы .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .  K = К,  L = Л,  M = М,  N = Н, O = О,  P = П,  Q = К,  R = Р,  S = С,  T = T, ~W = Щ, ~E = Э .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .  U = У,  V = В,  W = Ш,  X = Х, Y = Й,  Z = З, CH = Ч, SH = Ш, YU = Ю, YO = Ё,  ; = Ь, ~; = Ъ .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .  (ESC выход, BackSpace удалить букву, Enter новая строка, Delete удалить всё, Tab сохранить)  .");
            Console.WriteLine(" .                                                                                               .");
            Console.WriteLine(" .                                     Введите текст:                                            .");
            Console.WriteLine(" .................................................................................................");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in list)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" " + item);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write(" " + word);
            goto START;
            
            END:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВы успешно вышли с программы");
            Console.ForegroundColor = ConsoleColor.White;
            return 0;
        }
    }
}
