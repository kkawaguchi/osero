using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Game
    {
        private Rule rule;
        public Board Board { get; private set; }
        public StoneColor NextTurnColor{ get; private set; } 
        public bool HasEnd { get; private set; }


        public Game()
        {
            this.Board= new Board();
            this.rule = new Rule();
            SetInitialPosition();
            this.NextTurnColor = StoneColor.Black;
        }

        private void SetInitialPosition()
        {
            Board.GetCell(new CellPoint(4, 4)).SetStone(new Stone(StoneColor.Black));
            Board.GetCell(new CellPoint(5, 5)).SetStone(new Stone(StoneColor.Black));
            Board.GetCell(new CellPoint(4, 5)).SetStone(new Stone(StoneColor.White));
            Board.GetCell(new CellPoint(5, 4)).SetStone(new Stone(StoneColor.White));
        }

        public bool PutStone(CellPoint point,StoneColor color)
        {
            if (rule.CanPutStoneToCell(new Stone(color), this.Board.GetCell(point)))
            {
                rule.PutStoneToCell(new Stone(color), this.Board.GetCell(point));
                MoveToNextPalyer();
                return true;
            }
            return false;
        }

        public bool PutStone(int x, int y, StoneColor color)
        {
            return PutStone(new CellPoint(x,y),color);
        }

        private void MoveToNextPalyer()
        {
            if (NextPlayerCanPutStone(ChangeColor(this.NextTurnColor)))
            {
                ChangeNextTurnColor();
                return;
            }

            if (!NextPlayerCanPutStone(this.NextTurnColor))
            {
                this.HasEnd = true;
            }
        }

        private bool NextPlayerCanPutStone(StoneColor color)
        {

            foreach (Cell cell in this.Board.cells)
            {
                if (rule.CanPutStoneToCell(new Stone(color), cell))
                {
                    return true;
                }
            }
            return false;
        }

        private void ChangeNextTurnColor()
        {
            this.NextTurnColor = ChangeColor(this.NextTurnColor);
        }

        public StoneColor Winner()
        {
            int BlackCnt=this.Board.CountStone(StoneColor.Black);
            int WhiteCnt = this.Board.CountStone(StoneColor.White);

            if (BlackCnt == WhiteCnt)
            {
                return StoneColor.Yellow;
            }
            else if (BlackCnt > WhiteCnt)
            {
                return StoneColor.Black;
            }
            else
            {
                return StoneColor.White;
            }

        }

        private StoneColor ChangeColor(StoneColor color)
        {
            return color == StoneColor.Black ? StoneColor.White : StoneColor.Black;
        }
    }
}
