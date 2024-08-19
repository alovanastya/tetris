using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleTetris
{
    class Game
    {
        private Timer _timer;
        State CurrentState = new State();

        public void StartGame()
        {
            _timer = new Timer(1000); // интервал в 1 секунду
            _timer.Elapsed += (sender, e) => MoveToDown();
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public bool isPossibleMove(Block block)
        {


            return false;
        }

        public void MoveToRight()
        {
           
        }

        public void MoveToLeft()
        {
            
        }

        public void MoveToDown()
        {
            Print();
        }

        public void Rotate()
        {
            
        }

        public void Print() //напечатать игровое поле
        {
            Console.Clear();

            for(int i = 0; i < State.M; i++)
            {
                for(int j = 0; j < State.N; j++)
                {
                    if(CurrentState.GameBoard[i, j] == 0)
                    {
                        Console.Write(0);
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
