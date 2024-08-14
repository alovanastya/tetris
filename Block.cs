using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    struct Square
    {
        public Square(int i, int j){
            this.i = i;
            this.j = j;
        }
        public int i;
        public int j;
    }

    class Block
    {
        List<Square> coordinates;
        public List<Square> moveToRight() {
            return null;
        }
    }
}
