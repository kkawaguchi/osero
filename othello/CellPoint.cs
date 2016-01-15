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

        public override bool Equals(object obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            else
            {
                CellPoint p = (CellPoint)obj;
                return this.X == p.X && this.Y == p.Y;
            }
            
        }
    }

}
