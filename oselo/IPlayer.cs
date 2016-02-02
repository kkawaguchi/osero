using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oselo
{
    interface IPlayer
    {
        String Name { get; }
        StoneColor Color { get; }
        int[] SelectPoint(Board bood);
    }
}
