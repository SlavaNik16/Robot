using System;
using System.Security.Cryptography.X509Certificates;

namespace RobotGo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            Robot rob = new Robot();
            int i = 0;

            Console.WriteLine("Введите путь робота через клавиатуру (W - вверх, S - вниз, A - влево, D - вправо)\nЦель игры вернутся на место прибытия.\nУ вас максимум 20 ходов!");
            Console.WriteLine($"Ваши начальные координаты x = {rob.x}, y = {rob.y}");
            Console.SetCursorPosition(rob.x,rob.y);
            
            ConsoleKeyInfo key;
            Console.Write((char)(127));
            while (run)
            {
                key = Console.ReadKey(true);
                rob.Shag(ref key, ref rob.x, ref rob.y);
                Console.Write((char)(96));
                run = rob.End();
                i++;
            }
            Console.WriteLine();
            Console.WriteLine($"Ваши конечные координаты x = {rob.x}, y = {rob.y}");
            Console.WriteLine($"Всего шагов: {rob.count}");
            
        }
    }
}