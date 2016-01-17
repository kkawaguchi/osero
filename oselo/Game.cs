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
        public Board board = new Board();
        public Player nextPlayer = Player.BlackPlayer;
        public Rule rule;


        public Game()
        {
            this.rule = new Rule(this.board);
        }

        public void Start()
        {
            SetInitialPosition();
        }

        public void SetInitialPosition()
        {
            board.CellChange(new CellPoint(4, 4), new Stone(player1.Color));
            board.CellChange(new CellPoint(5, 5), new Stone(player1.Color));
            board.CellChange(new CellPoint(4, 5), new Stone(player2.Color));
            board.CellChange(new CellPoint(5, 4), new Stone(player2.Color));
        }

        public bool PutStone(CellPoint point,Player player)
        {
            //TODO:ルールでおけるがどうか調べる
            return rule.CheckPutStone(this.board.GetCell(point), player);
            //board.CellChange(point, new Stone(player.Color));
            //ChangeNextPlayer();
        }

        public void NextPalyer(Player player)
        {
            foreach(Cell cell in this.board.cells)
            {
                if(rule.CheckPut(cell,player))
                {
                    ChangeNextPlayer();
                    break;
                }
            }
        }

        public CellPoint GetPoint(int[] point)
        {
            return new CellPoint(point[0],point[1]);
        }

        private void ChangeNextPlayer()
        {
            this.nextPlayer = this.nextPlayer.Color == StoneColor.Black ? this.player2 : this.player1;
        }
    }
}
