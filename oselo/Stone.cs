using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oselo
{
    class Stone
    {
        public StoneColor color { get; private set; }

        public Stone(StoneColor color)
        {
            this.color = color;
        }
    }
}
