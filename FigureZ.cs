using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    public class FigureZ : Block
    {
        public FigureZ(int i, int j): base(i, j)
        {
            BlockType = 6;

            BlockMatrix = new int[4, 4]{
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 1, 1, 0 },
            { 0, 0, 1, 1 }
            };

        }
    }
}
