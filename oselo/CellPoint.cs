using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oselo
{
    class CellPoint
    {
        public  int X { get; private set; }
        public int Y { get; private set; }

        public CellPoint(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
