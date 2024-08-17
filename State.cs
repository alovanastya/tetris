using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    class State
    {
        Block nextBlock;
        Block activeBlock;

        int[,] gameBoard = new int[20, 10];

        private void generateNextBlokc()
        {

        }

        public void endMove() //выполняется после каждого завершения хода
        {
            
        }

        public State() 
        { 
            // конструктор пустой 
        }

        // здесь владимир напишет конструктор для поля :)

    }
}
