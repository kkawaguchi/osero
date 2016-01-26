using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Game
    {
        public int Turn = 0;
        private Player player1 = Player.BlackPlayer;
        private Player player2 = Player.WhitePlayer;
        private Rule rule;
        public Board Board { get; private set; }
        public Player NextPlayer{ get; private set; } 
        public bool HasEnd { get; private set; }


        public Game()
        {
            this.Board= new Board();
            this.rule = new Rule();
            SetInitialPosition();
            this.NextPlayer = player1;
        }

        private void SetInitialPosition()
        {
            Board.GetCell(new CellPoint(4, 4)).SetStone(new Stone(player1.Color));
            Board.GetCell(new CellPoint(5, 5)).SetStone(new Stone(player1.Color));
            Board.GetCell(new CellPoint(4, 5)).SetStone(new Stone(player2.Color));
            Board.GetCell(new CellPoint(5, 4)).SetStone(new Stone(player2.Color));
        }

        public bool PutStone(CellPoint point,Player player)
        {
            if (rule.CanPutStoneToCell(new Stone(player.Color), this.Board.GetCell(point)))
            {
                rule.PutStoneToCell(new Stone(player.Color),this.Board.GetCell(point));
                MoveToNextPalyer();
                return true;
            }
            return false;
        }

        public bool PutStone(int x,int y, Player player)
        {
            return PutStone(new CellPoint(x,y),player);
        }

        private void MoveToNextPalyer()
        {
            if (NextPlayerCanPutStone(this.NextPlayer.OpsitPlayer()))
            {
                ChangeNextPlayer();
                return;
            }

            if (!NextPlayerCanPutStone(this.NextPlayer))
            {
                this.HasEnd = true;
            }
        }

        private bool NextPlayerCanPutStone(Player player)
        {

            foreach (Cell cell in this.Board.cells)
            {
                if (rule.CanPutStoneToCell(new Stone(player.Color), cell))
                {
                    return true;
                }
            }
            return false;
        }

        private void ChangeNextPlayer()
        {
            this.NextPlayer = NextPlayer.OpsitPlayer();
        }

        public Player Winner()
        {
            int BlackCnt=this.Board.CountStone(StoneColor.Black);
            int WhiteCnt = this.Board.CountStone(StoneColor.White);

            if (BlackCnt == WhiteCnt)
            {
                return null;
            }
            else if (BlackCnt > WhiteCnt)
            {
                return player1;
            }
            else
            {
                return player2;
            }

        }
    }
}
