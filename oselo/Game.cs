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
        public Board board{get; private set;} 

        public Game()
        {
            this.player1 = Player.BlackPlayer;
            this.player2 = Player.WhitePlayer;
        }

        public void Start()
        {

        }

        public void CreateBord()
        {
            this.board =  new Board();
        }

        public void SetInitialPosition()
        {


        }

    }
}
