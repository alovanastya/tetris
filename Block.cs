using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    struct SquareOnTheField // это один квадратик поля, их 200
    {
        public SquareOnTheField(int i, int j)
        {
            this.i = i;
            this.j = j;
        }

        public int i;
        public int j;
    }

    class Block
    {

        int blockType;

        List<SquareOnTheField> coordinates;
        public List<SquareOnTheField> moveToRight() 
        {
            return null; // нул по приколу пока
        }
        public List<SquareOnTheField> moveToLeft()
        {
            return null; // нул по приколу пока
        }

        public List<SquareOnTheField> moveDown()
        {
            return null; // нул по приколу пока
        }

        public List<SquareOnTheField> rotate()
        {
            return null; // нул по приколу пока
        }
    }
}
