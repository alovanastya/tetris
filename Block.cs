using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    class Block
    {
        Block(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        Block() { }

        int blockType;

        public int i = 0;
        public int j = 0;

        public bool[,] blockMatrix = new bool[4, 4];

        public void moveToRight() 
        {
            j++;
        }
        public void moveToLeft()
        {
            j--;
        }

        public void moveDown()
        {
            i++;
        }

        public void rotate()
        {
            
        }
    }
}
