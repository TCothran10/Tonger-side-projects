﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer_Random_campaign_generator
{
    public class LordsInfo
    {

        public string LordName { get; set; }

        public string GoodOrEvil { get; set; }
        x
        public int StartingZone { get; set; }



        public LordsInfo(string lordName, string goodOrEvil, int startingZone)
        {
            LordName = lordName;
            GoodOrEvil = goodOrEvil;
            StartingZone = startingZone;
        }


        public override string ToString()
        {
            return LordName + GoodOrEvil + StartingZone;
        }
    }
}
