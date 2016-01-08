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
                    cells.Add(CreateCell(i, j));
                } 
            }
        }

        private Cell CreateCell(int x, int y)
        {
            return new Cell(x,y);
        }

        private Cell GetCell(int x, int y)
        {
            var cell = this.cells.Where(p => p.X == x && p.Y == y).Select(p => p);
            return cell.First<Cell>();
        }
    }
}
