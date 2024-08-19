using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTetris
{
    class State
    {
        public const int M = 20;
        public const int N = 10;

        public Block NextBlock;
        public Block AtiveBlock;

        public int[,] GameBoard = new int[M, N];

        private Block GenerateRandomBlock()  // создает и возввращает рандомную фигурку
        {
            Random rnd = new Random();

            int BlockTypeIndex = rnd.Next(1, 8);

            switch (BlockTypeIndex)
            {
                case 1:
                    return new FigureJ(-3, 8);

                case 2:
                    return new FigureL(-3, 8);

                case 3:
                    return new FigureO(-3, 8);

                case 4:
                    return new FigureS(-3, 8);

                case 5:
                    return new FigureT(-3, 8);
    
                case 6:
                    return new FigureZ(-3, 8);

                case 7:
                    return new FigureI(-3, 8);

                    default: return null;
            }
        }

        private Block GenerateNextBlock()
        {
            return GenerateRandomBlock();
        }

        public void EndMove() //выполняется после каждого завершения хода
        {

        }

        public State()
        {
            // конструктор пустой 
        }

        // здесь владимир напишет конструктор для поля :)

    }
}
