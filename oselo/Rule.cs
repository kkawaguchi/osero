
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
        private Cell cell;

        public Rule(Board board)
        {
            this.Board = board;
            this.cell = null;
        }

        public bool CheckPutStone(Cell cell, Player player)
        {
            bool checkFlg = false;
            if(cell.Stone != null )
            {
                return false;
            }
            if(UECheck(cell,player))
            {
                UEChange(cell, player);
                checkFlg = true;
            }

            if (SHITACheck(cell, player))
            {
                SHITAChange(cell, player);
                checkFlg = true;
            }

            if (MIGICheck(cell, player))
            {
                MIGIChange(cell, player);
                checkFlg = true;
            }

            if (HIDARICheck(cell, player))
            {
                HIDARIChange(cell, player);
                checkFlg = true;
            }

            if (MIGIUECheck(cell, player))
            {
                MIGIUEChange(cell, player);
                checkFlg = true;
            }

            if (MIGISHITACheck(cell, player))
            {
                MIGISHITAChange(cell, player);
                checkFlg = true;
            }

            if (HIDARIUECheck(cell, player))
            {
                HIDARIUEChange(cell, player);
                checkFlg = true;
            }

            if (HIDARISHITACheck(cell, player))
            {
                HIDARISHITAChange(cell, player);
                checkFlg = true;
            }

            return checkFlg;
        }

        public bool CheckPut(Cell cell, Player player)
        {
            return UECheck(cell, player) || SHITACheck(cell, player) || MIGICheck(cell, player) || HIDARICheck(cell, player) || MIGIUECheck(cell, player) || MIGISHITACheck(cell, player) || MIGISHITACheck(cell, player) || HIDARISHITACheck(cell, player) || HIDARIUECheck(cell, player);
        }

        private bool UECheck(Cell cell, Player player)
        {
            this.cell = cell.GetUE();
            while(this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetUE();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void UEChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetUE();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetUE();
            }
        }

        private bool SHITACheck(Cell cell, Player player)
        {
            this.cell = cell.GetSHITA();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetSHITA();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void SHITAChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetSHITA();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetSHITA();
            }
        }

        private bool MIGICheck(Cell cell, Player player)
        {
            this.cell = cell.GetMIGI();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetMIGI();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void MIGIChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetMIGI();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetMIGI();
            }
        }

        private bool HIDARICheck(Cell cell, Player player)
        {
            this.cell = cell.GetHIDARI();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetHIDARI();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void HIDARIChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetHIDARI();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetHIDARI();
            }
        }

        private bool MIGIUECheck(Cell cell, Player player)
        {
            this.cell = cell.GetMIGIUE();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetMIGIUE();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void MIGIUEChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetMIGIUE();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetMIGIUE();
            }
        }

        private bool MIGISHITACheck(Cell cell, Player player)
        {
            this.cell = cell.GetMIGISHITA();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetMIGISHITA();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void MIGISHITAChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetMIGISHITA();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetMIGISHITA();
            }
        }

        private bool HIDARIUECheck(Cell cell, Player player)
        {
            this.cell = cell.GetHIDARIUE();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetHIDARIUE();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void HIDARIUEChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetHIDARIUE();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetHIDARIUE();
            }
        }

        private bool HIDARISHITACheck(Cell cell, Player player)
        {
            this.cell = cell.GetHIDARISHITA();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.cell = this.cell.GetHIDARISHITA();
            }
            return this.cell != null && this.cell.Stone != null && this.cell.Stone.Color == player.Color ? true : false;
        }

        private void HIDARISHITAChange(Cell cell, Player player)
        {
            this.Board.CellChange(cell.Point, new Stone(player.Color));
            this.cell = cell.GetHIDARISHITA();
            while (this.cell != null && this.cell.Stone != null && this.cell.Stone.Color != player.Color)
            {
                this.Board.CellChange(this.cell.Point, new Stone(player.Color));
                this.cell = this.cell.GetHIDARISHITA();
            }
        }


    }
}
