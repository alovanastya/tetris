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

        public void Rotate() // на 90
        {
            int[,] matrix_2 = new int[4, 4];

            // matrix_2 - перевернутая BlockMatrix
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrix_2[j, i]  = BlockMatrix[(4 - i - 1), j];
                }
            }

            // поворот BlockMatrix
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    BlockMatrix[j, i] = matrix_2[j, i];
                }
            }
        }

        public Block Clone()
        {
            Block block = new Block(i, j);

            block.BlockType = BlockType;

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    block.BlockMatrix[i, j] = BlockMatrix[i, j];
                }
            }
            return block;
        }
    }
}
