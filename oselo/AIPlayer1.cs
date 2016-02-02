using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oselo
{
    class AIPlayer1:IPlayer
    {
        public StoneColor Color { get; private set; }
        public String Name { get; private set; }
        private Rule rule;
        public AIPlayer1(StoneColor color)
        {
            this.Color = color;
            this.Name = "tatou";
            this.rule = new Rule();
        }

        public int[] SelectPoint(Board board)
        {
            foreach (Cell cell in board.cells)
            {
                if (rule.CanPutStoneToCell(new Stone(this.Color), cell))
                {
                    return new int[2] {cell.Point.X,cell.Point.Y};
                }
            }
            return new int[2] { 0, 0 };
        }


    }
}
