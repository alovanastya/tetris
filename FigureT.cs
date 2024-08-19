using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    public class FigureT : Block
    {
        public FigureT(int i, int j): base(i, j)
        {
            BlockType = 5;

            BlockMatrix = new int[4, 4]{
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 1, 1, 1 },
            { 0, 0, 1, 0 }
            };
        }
    }
}
