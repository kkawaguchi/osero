
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Rule
    {
        private static Direction[] directions = (Direction[])Enum.GetValues(typeof(Direction)); 
        public Rule()
        {
        }

        public void PutStoneToCell(Stone stone, Cell cell)
        {
            cell.SetStone(stone);

            for (int i = 0; i < 8; i++)
            {
                if (CheckOneDirection(cell, stone, directions[i]))
                    //チェックOKなら色を変える
                    ChangeCell(cell, stone, directions[i]);
            }
        }

        public bool CanPutStoneToCell(Stone stone, Cell cell)
        {
            if (cell.Stone != null) return false;
            for (int i = 0; i < 8;i++ )
            {
                if (CheckOneDirection(cell, stone, directions[i])) return true;
            }
            return false;
        }

        private bool CheckOneDirection(Cell cell, Stone stone, Direction direction)
        {
            Cell next = cell.GetNextCell(direction);

            //1つ上がない場合は置けない
            if (next == null || !next.HasStone) return false;

            //1つ上がプレイヤーと同じ色の場合は置けない
            if (stone.Color == next.Stone.Color) return false;

            //1つ上に石がある間続ける
            while ((next = next.GetNextCell(direction)) != null && next.HasStone)
            {
                //自分と同じ色なら置ける
                if (stone.Color == next.Stone.Color)
                {
                    return true;
                }
            }
            return false;
        }
        
        private void ChangeCell(Cell cell, Stone stone, Direction direction)
        {
            Cell next = cell;
            //1つ上に石がある間続ける
            while ((next = next.GetNextCell(direction)) != null && next.HasStone)
            {
                //自分と違う色なら色を変える
                if (stone.Color != next.Stone.Color)
                {
                    next.Change();
                }
                else return;
            }
        }
    }
}
