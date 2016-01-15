using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Game
    {
        public List<BoardState> story = new List<BoardState>();
        public int Turn = 0;
        private Player player1;
        private Player player2;
        public Board board = new Board();
        public Player nextPlayer;


        public Game()
        {
            this.player1 = Player.BlackPlayer;
            this.player2 = Player.WhitePlayer;
            this.nextPlayer = Player.BlackPlayer;
        }

        public void Start()
        {
            SetInitialPosition();

        }

        
        public void SetInitialPosition()
        {
            PutStone(new CellPoint(4, 4), new Stone(StoneColor.Black));
            PutStone(new CellPoint(5, 5), new Stone(StoneColor.Black));
            PutStone(new CellPoint(4, 5), new Stone(StoneColor.White));
            PutStone(new CellPoint(5, 4), new Stone(StoneColor.White));
        }

        public void PutStone(CellPoint point,Stone stone)
        {
            //TODO:ルールでおけるがどうか調べる
            board.CellChange(point, stone);
        }

        public Player NextPalyer()
        {

        }
    }
}
