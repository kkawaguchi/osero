using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oselo
{
    class AIPlayer2:IPlayer
    {
        public StoneColor Color { get; private set; }
        public String Name { get; private set; }
        private Rule rule;
        private int[,] evaluation = new int[8,8];
        public AIPlayer2(StoneColor color)
        {
            this.Color = color;
            this.Name = "ziro";
            this.rule = new Rule();
            CreateEvaluation();
        }

        public int[] SelectPoint(Board board)
        {
            int maxEvaluation = 0;
            int[] point = new int[2];
            foreach (Cell cell in board.cells)
            {
                if (rule.CanPutStoneToCell(new Stone(this.Color), cell))
                {
                    if (maxEvaluation < evaluation[cell.Point.X-1, cell.Point.Y-1])
                    {
                        point[0] = cell.Point.X;
                        point[1] = cell.Point.Y;
                    }
                }
            }
            return point;
        }

        private void CreateEvaluation()
        {
           //for (int i = 0; i < 8; i++)
           // {
           //     for (int j = 0; j < 8; j++)
           //     {

           //     }
           //}
            evaluation[0, 0] = 30;
            evaluation[0, 1] = 1;
            evaluation[0, 2] = 25;
            evaluation[0, 3] = 20;
            evaluation[0, 4] = 20;
            evaluation[0, 5] = 25;
            evaluation[0, 6] = 1;
            evaluation[0, 7] = 30;
            evaluation[1, 0] = 1;
            evaluation[1, 1] = 1;
            evaluation[1, 2] = 5;
            evaluation[1, 3] = 10;
            evaluation[1, 4] = 10;
            evaluation[1, 5] = 5;
            evaluation[1, 6] = 1;
            evaluation[1, 7] = 1;
            evaluation[2, 0] = 25;
            evaluation[2, 1] = 5;
            evaluation[2, 2] = 23;
            evaluation[2, 3] = 20;
            evaluation[2, 4] = 20;
            evaluation[2, 5] = 23;
            evaluation[2, 6] = 5;
            evaluation[2, 7] = 25;
            evaluation[3, 0] = 20;
            evaluation[3, 1] = 10;
            evaluation[3, 2] = 20;
            evaluation[3, 3] = 1;
            evaluation[3, 4] = 1;
            evaluation[3, 5] = 20;
            evaluation[3, 6] = 10;
            evaluation[3, 7] = 20;
            evaluation[4, 0] = 20;
            evaluation[4, 1] = 10;
            evaluation[4, 2] = 20;
            evaluation[4, 3] = 1;
            evaluation[4, 4] = 1;
            evaluation[4, 5] = 20;
            evaluation[4, 6] = 10;
            evaluation[4, 7] = 20;
            evaluation[5, 0] = 25;
            evaluation[5, 1] = 5;
            evaluation[5, 2] = 23;
            evaluation[5, 3] = 20;
            evaluation[5, 4] = 20;
            evaluation[5, 5] = 23;
            evaluation[5, 6] = 5;
            evaluation[5, 7] = 25;
            evaluation[6, 0] = 1;
            evaluation[6, 1] = 1;
            evaluation[6, 2] = 5;
            evaluation[6, 3] = 10;
            evaluation[6, 4] = 10;
            evaluation[6, 5] = 5;
            evaluation[6, 6] = 1;
            evaluation[6, 7] = 1;
            evaluation[7, 0] = 30;
            evaluation[7, 1] = 1;
            evaluation[7, 2] = 25;
            evaluation[7, 3] = 20;
            evaluation[7, 4] = 20;
            evaluation[7, 5] = 25;
            evaluation[7, 6] = 1;
            evaluation[7, 7] = 30;

        }


    }
}
