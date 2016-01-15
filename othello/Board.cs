using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Board
    {
        private List<Cell> cells = new List<Cell>();

        public Board()
        {   

            for(int i = 1 ; i <= 8 ; i++ )
            {
                for (int j = 1; j <= 8 ; j++ )
                {
                    cells.Add(new Cell(i,j));
                } 
            }
        }

        private Cell GetCell(CellPoint point)
        {
            var cell = this.cells.Where(c => c.Point.Equals(point));
            return cell.First<Cell>();
        }

        public void CellChange(CellPoint point, Stone stone)
        {
            GetCell(point).Stone = stone == null ? null : stone;
        }

    }
}
