using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    public class FigureO : Block
    {
        FigureO()
        {
            blockType = 3;

            blockMatrix = new int[4, 4]{
            { 0, 0, 0, 0 },
            { 0, 0, 0, 0 },
            { 0, 1, 1, 0 },
            { 0, 1, 1, 0 }
            };
        }
    }
}