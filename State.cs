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
        public Block ActiveBlock;

        public int[,] GameBoard = new int[M, N];

        private Block GenerateRandomBlock()  // создает и возввращает рандомную фигурку
        {
            Random rnd = new Random();

            int BlockTypeIndex = rnd.Next(1, 8);

            switch (BlockTypeIndex)
            {
                case 1:
                    return new FigureJ(-3, 4);

                case 2:
                    return new FigureL(-3, 4);

                case 3:
                    return new FigureO(-3, 4);

                case 4:
                    return new FigureS(-3, 4);

                case 5:
                    return new FigureT(-3, 4);
    
                case 6:
                    return new FigureZ(-3, 4);

                case 7:
                    return new FigureI(-3, 8);

                    default: return null;
            }
        }

        public void AddActiveBlock() // добавляет активную фигуру в стакан
        {
            for(int i = 0; i < 4 && ActiveBlock.i + i < M; i++)
            {
                if (ActiveBlock.i + i < 0)
                    continue;
                for(int j = 0; j < 4 && ActiveBlock.j + j < N; j++)
                {
                    if (ActiveBlock.j + j < 0)
                        continue;
                    if(ActiveBlock.BlockMatrix[i, j] == 1)
                    {
                        GameBoard[ActiveBlock.i + i, ActiveBlock.j + j] = ActiveBlock.BlockType;
                    }
                }
            }
        }

        public void DeleteActiveBlock()
        {
            for (int i = 0; i < 4 && ActiveBlock.i + i < M; i++)
            {
                if (ActiveBlock.i + i < 0)
                    continue;
                for (int j = 0; j < 4 && ActiveBlock.j + j < N; j++)
                {
                    if (ActiveBlock.j + j < 0)
                        continue;
                    if (ActiveBlock.BlockMatrix[i, j] == 1)
                    {
                        GameBoard[ActiveBlock.i + i, ActiveBlock.j + j] = 0;
                    }
                }
            }
        }

        public void EndMove() //выполняется после каждого завершения хода
        {

        }

        public State()
        {
            ActiveBlock = GenerateRandomBlock();
            NextBlock = GenerateRandomBlock();
            AddActiveBlock();
        }
    }
}
