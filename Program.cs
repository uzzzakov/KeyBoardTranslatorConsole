using System;

namespace KeyBoardTranslator
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Введите текст: (ESC для выхода, BackSpace удалить последнюю букву) ");
            ConsoleKey key = new ConsoleKey();
            string word = "";
            START:
            key = Console.ReadKey(true).Key;
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
            
            if (key == ConsoleKey.OemPeriod) 
                word += '.';
            if (key == ConsoleKey.OemComma)
                word += ',';
            if (key == ConsoleKey.Spacebar)
                word += ' ';
            if (key == ConsoleKey.Oem2)
                word += '?';
            if (key == ConsoleKey.Oem7)
                word += 'Ь';
            if (key == ConsoleKey.Oem3)
                word += '~';
            if (key == ConsoleKey.Backspace)
            {
                if (word != "")
                    word = word.Substring(0, word.Length-1);
            }
            if (key == ConsoleKey.Escape)
            {
                goto END;
            }
            /*else
                Console.Write(key);*/
            Console.Clear();
            Console.WriteLine("Введите текст: (ESC для выхода, BackSpace удалить последнюю букву) ");
            Console.Write(word);
            goto START;
            
            END:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nВы успешно вышли с программы");
            Console.ForegroundColor = ConsoleColor.White;
            return 0;
        }
    }
}
