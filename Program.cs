using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleTetris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Game game = new Game();
            game.StartGame();
            
            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.W)
                {
                    game.Rotate();
                }
                if (keyInfo.Key == ConsoleKey.A)
                {
                    game.MoveToLeft();
                }
                if (keyInfo.Key == ConsoleKey.S)
                {
                    game.MoveToDown();
                }
                if (keyInfo.Key == ConsoleKey.D)
                {
                    game.MoveToRight();
                }
            }
            Console.ReadKey();
        }
    }
}
