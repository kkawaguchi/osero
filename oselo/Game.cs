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
        public int Turn;
        private Player player1;
        private Player player2;

        public Game()
        {
            this.player1 = Player.BlackPlayer;
            this.player2 = Player.WhitePlayer;
        }

        public void Start()
        {

        }

        public Board CreateBord()
        {
            return new Board();
        }

    }
}
