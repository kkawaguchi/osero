
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Rule
    {
        public Board Board { get;private set; }
        private static Direction[] directions = (Direction[])Enum.GetValues(typeof(Direction)); 
        public Rule(Board board)
        {
            this.Board = board;
        }

        public void ChangeAllStone(Cell cell, Player player)
        {
            if (cell.Stone != null) return;

            this.Board.CellChange(cell.Point, new Stone(player.Color));

            for (int i = 0; i < 8; i++)
            {
                if (CheckOneDirection(cell, player, directions[i]))
                    //チェックOKなら色を変える
                    ChangeStone(cell, player, directions[i]);
            }
        }

        public bool CheckAllDirection(Cell cell, Player player)
        {
            if (cell.Stone != null) return false;
            for (int i = 0; i < 8;i++ )
            {
                if (CheckOneDirection(cell, player, directions[i])) return true;
            }
            return false;
        }

        private bool CheckOneDirection(Cell cell, Player player,Direction direction)
        {
            Cell next = cell.GetNextCell(direction);

            //1つ上がない場合は置けない
            if (next == null || !next.HasStone) return false;

            //1つ上がプレイヤーと同じ色の場合は置けない
            if (player.Color == next.Stone.Color) return false;

            //1つ上に石がある間続ける
            while ((next = next.GetNextCell(direction)) != null && next.HasStone)
            {
                //自分と同じ色なら置ける
                if( player.Color == next.Stone.Color)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void ChangeStone(Cell cell, Player player,Direction direction)
        {
            Cell next = cell;
            //1つ上に石がある間続ける
            while ((next = next.GetNextCell(direction)) != null && next.HasStone)
            {
                //自分と違う色なら色を変える
                if (player.Color != next.Stone.Color)
                {
                    this.Board.CellChange(next.Point, new Stone(player.Color));
                }
                else return;
            }
        }
    }
}
