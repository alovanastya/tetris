using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    class State
    {
        public const int M = 20;
        public const int N = 10;

        public Block NextBlock;
        public Block AtiveBlock;

        public int[,] GameBoard = new int[M, N];

        private void GenerateNextBlock()
        {

        }

        public void EndMove() //выполняется после каждого завершения хода
        {
            
        }

        public State() 
        { 
            // конструктор пустой 
        }

        // здесь владимир напишет конструктор для поля :)

    }
}
