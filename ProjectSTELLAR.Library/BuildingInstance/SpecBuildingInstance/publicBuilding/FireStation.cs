﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStellar.Library
{ 
    class FireStation : Building
    {

    float _x;
    float _y;
        public FireStation(float x, float y)
            : base()
        {
        _x = x;
        _y = y;
        }
    }
}
