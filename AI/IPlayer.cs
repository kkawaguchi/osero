﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AI
{
    interface IPlayer
    {
        String Name{get;}
        void SelectPoint();
    }
}
