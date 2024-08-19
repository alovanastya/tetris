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
            _timer = new Timer(500);
            _timer.Elapsed += (sender, e) => MoveToDown();
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public bool IsPossibleBlock(Block block)
        {
            return true;
        }

        public void MoveToRight()
        {
            CurrentState.DeleteActiveBlock();
            Block block = CurrentState.ActiveBlock.Clone();
            block.MoveToRight();
            if (IsPossibleBlock(block))
            {
                CurrentState.ActiveBlock = block;
            }
            CurrentState.AddActiveBlock();
            Print();
        }

        public void MoveToLeft()
        {
            CurrentState.DeleteActiveBlock();
            Block block = CurrentState.ActiveBlock.Clone();
            block.MoveToLeft();
            if (IsPossibleBlock(block))
            {
                CurrentState.ActiveBlock = block;
            }
            CurrentState.AddActiveBlock();
            Print();
        }

        public void MoveToDown()
        {
            CurrentState.DeleteActiveBlock();
            Block block = CurrentState.ActiveBlock.Clone();
            block.MoveDown();
            if (IsPossibleBlock(block))
            {
                CurrentState.ActiveBlock = block;
            }
            CurrentState.AddActiveBlock();
            Print();
        }

        public void Rotate()
        {
            CurrentState.DeleteActiveBlock();
            Block block = CurrentState.ActiveBlock.Clone();
            block.Rotate();
            if (IsPossibleBlock(block))
            {
                CurrentState.ActiveBlock = block;
            }
            CurrentState.AddActiveBlock();
            Print();
        }

        public void Print()
        {
            int indent = 4; // Количество пробелов для отступа

            // Сохраняем текущую позицию курсора
            int cursorTop = Console.CursorTop;

            // Устанавливаем курсор в начало
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < State.M; i++)
            {
                // Устанавливаем курсор на нужную позицию с отступом
                Console.SetCursorPosition(indent, i);

                for (int j = 0; j < State.N; j++)
                {
                    if (CurrentState.GameBoard[i, j] == 0)
                    {
                        Console.Write(".");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                    Console.Write(" ");
                }
            }

            // Устанавливаем курсор обратно в исходное положение
            Console.SetCursorPosition(0, cursorTop);
        }


    }
}
