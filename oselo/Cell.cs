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
        public Board Board { get; private set; }

        public Stone Stone { get; set; }

        public Cell(CellPoint point,Board board)
        {
            this.Point = point;
            this.Stone = null;
            this.Board = board;
        }

        public Cell(int x,int y,Board board):this(new CellPoint(x,y),board)
        {
        }

        public Cell GetNextCell(Direction direction)
        {
            switch (direction)
            {
                case Direction.Ue: return GetUE();
                case Direction.Shita: return GetSHITA();
                case Direction.Migi: return GetMIGI();
                case Direction.Hidari: return GetHIDARI();
                case Direction.MigiUe: return GetMIGIUE();
                case Direction.MigiShita: return GetMIGISHITA();
                case Direction.HidariUe: return GetHIDARIUE();
                default :return GetHIDARISHITA();
            }       
        }

        public Cell GetUE()
        {
            if(this.Point.Y == 1)
            {
                return null;
            }
            else
            {
                return this.Board.GetCell(new CellPoint(this.Point.X,this.Point.Y-1));
            }
        }

        public Cell GetSHITA()
        {
            if (this.Point.Y == 8)
            {
                return null;
            }
            else
            {
                return this.Board.GetCell(new CellPoint(this.Point.X, this.Point.Y + 1));
            }
        }

        public Cell GetMIGI()
        {
            if (this.Point.X == 8)
            {
                return null;
            }
            else
            {
                return this.Board.GetCell(new CellPoint(this.Point.X + 1, this.Point.Y));
            }
        }

        public Cell GetHIDARI()
        {
            if (this.Point.X == 1)
            {
                return null;
            }
            else
            {
                return this.Board.GetCell(new CellPoint(this.Point.X - 1, this.Point.Y));
            }
        }

        public Cell GetMIGIUE()
        {
            if (this.GetUE() == null)
            {
                return null;
            }
            else
            {
                return this.GetUE().GetMIGI();
            }
        }

        public Cell GetHIDARIUE()
        {
            if (this.GetUE() == null)
            {
                return null;
            }
            else
            {
                return this.GetUE().GetHIDARI();
            }
        }

        public Cell GetMIGISHITA()
        {
            if (this.GetSHITA() == null)
            {
                return null;
            }
            else
            {
                return this.GetSHITA().GetMIGI();
            }
        }

        public Cell GetHIDARISHITA()
        {
            if (this.GetSHITA() == null)
            {
                return null;
            }
            else
            {
                return this.GetSHITA().GetHIDARI();
            }
        }

        public bool HasStone { get { return this.Stone != null; } }
    }
}
