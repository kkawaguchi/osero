using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Cell
    {
        public CellPoint Point { get; private set; }

        public Stone Stone { get; set; }

        public Cell(CellPoint point)
        {
            this.Point = point;
            this.Stone = null;
        }

        public Cell(int x,int y):this(new CellPoint(x,y))
        {
        }
    }
}
