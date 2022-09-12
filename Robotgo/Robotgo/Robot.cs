using System;


namespace Robotgo
{
    class Robot
    {
        public int x = Console.WindowWidth / 2;
        public int y = Console.WindowHeight / 2;
        public int count = 0;

        public void Shag(ref ConsoleKeyInfo key, ref int x, ref int y)
        {

            if (key.KeyChar == 119 || key.KeyChar == 87)
            {
                Console.SetCursorPosition(x, --y);
                Console.Write((char)(30));
            }
            else if (key.KeyChar == 115 || key.KeyChar == 83)
            {
                Console.SetCursorPosition(x, ++y);
                Console.Write((char)(31));
            }
            else if (key.KeyChar == 97 || key.KeyChar == 65)
            {
                Console.SetCursorPosition(--x, y);
                Console.Write((char)(17));
            }
            else if (key.KeyChar == 100 || key.KeyChar == 68)
            {
                Console.SetCursorPosition(++x, y);
                Console.Write((char)(16));
            }

            count++;

        }

        public bool End()
        {
            if ((x == (Console.WindowWidth / 2) && y == (Console.WindowHeight / 2)) || count > 20) 
            {
                if (count > 20)
                {
                    Console.WriteLine("Нет пути домой!!!");
                }
                return false;
            }
            return true;


        }
    }
}
