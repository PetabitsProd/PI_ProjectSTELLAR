﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStellar.Library
{ 
    class Flat : Building
    {
        float _x;
        float _y;
        public Flat(float x, float y)
            : base()
        {
        _x = x;
        _y = y;
        }
    }
}
