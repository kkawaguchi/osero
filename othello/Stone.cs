using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Stone
    {
        public StoneColor Color { get; private set; }

        public Stone(StoneColor color)
        {
            this.Color = color;
        }

        public void ChangeColor()
        {
            this.Color = this.Color == StoneColor.Black ? StoneColor.White : StoneColor.Black;
        }
    }
}
