using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    public class FigureL : Block
    {
        public FigureL(int i, int j): base(i, j)
        {
            BlockType = 2;

            BlockMatrix = new int[4, 4]{
            { 0, 1, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 1, 0, 0 },
            { 0, 1, 1, 0 }
            };
        }
    }
}
