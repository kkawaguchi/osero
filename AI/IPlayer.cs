using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI
{
    interface IPlayer
    {
        public String Name { get; private set; }
        public void SelectPoint();
    }
}
