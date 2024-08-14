using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    class State
    {
        Block activeBlock;
        int[,] gameBoard = new int[20, 10];
    }
}
