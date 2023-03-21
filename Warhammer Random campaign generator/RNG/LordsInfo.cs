using System;
using System.Collections.Generic;
using System.Text;

namespace RNG
{
    //Instanciating all the info for lords
    public class LordsInfo
    {

        public string LordName { get; set; }

        public string GoodOrEvil { get; set; }

        public int StartingZone { get; set; }

        public bool IsAvailable { get; set; } = true;



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
