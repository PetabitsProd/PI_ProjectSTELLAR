﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStellar
{
    public class PumpingStation : Building
    {
        int _waterProduction;
        public PumpingStation(Map ctx, int waterProduction)
            : base(ctx, 25, 38, 25, 30, 30, 0, 15, 15, true, 12, 200)
        {
            _waterProduction = waterProduction;
        }

        public int WaterProduction => _waterProduction;
    
    }
}
