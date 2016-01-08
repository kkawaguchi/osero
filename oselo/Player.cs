using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Player
    {
        public static Player BlackPlayer = new Player(StoneColor.Black);
        public static Player WhitePlayer = new Player(StoneColor.White);

        public StoneColor Color { get; private set; }

        private Player(StoneColor color)
        {
            this.Color = color;
        }

        public CellPoint PutStone(int x,int y)
        {
            return false;
        }


    }
}
