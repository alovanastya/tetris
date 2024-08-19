using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
   public class Block
    {
        public Block(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public int BlockType;

        public int i = 0;
        public int j = 0;

        public int[,] BlockMatrix = new int[4, 4];

        public void MoveToRight() 
        {
            j++;
        }
        public void MoveToLeft()
        {
            j--;
        }

        public void MoveDown()
        {
            i++;
        }

        public void Rotate()
        {
 
        }
    }
}
