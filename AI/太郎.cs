﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI
{
    class 太郎:IPlayer
    {
        public String Name { get; private set; }
        public 太郎()
        {
            this.Name = "太郎";
        }

        public void SelectPoint()
        {
        }
    }
}
