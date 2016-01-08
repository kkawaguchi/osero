using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oselo
{
    //盤保存用クラス
    class BoardState
    {
        public int Turn { get; private set; }
        private Board Board;

        public BoardState(int turn, Board board)
        {
            this.Turn = turn;
            this.Board = board;
        }
    }
}
