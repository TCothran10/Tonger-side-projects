using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace RNG
{
    public class LordCSVInsert
    {

        public string InsertLords(LordInfoUse lordsInfoUse)
        {
            string csvFilePath = @"C:\Users\Student\Tonger-side-projects\Warhammer Random campaign generator\Lords.csv";

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                while (!reader.EndOfStream)
                {
                    string lordInfo = reader.ReadLine();

                    string[] lordBreakdown = lordInfo.Split("|");
                    string lordName = lordBreakdown[0];
                    string goodOrEvil = lordBreakdown[1];
                    int startingZone = int.Parse(lordBreakdown[2]);

                    if (goodOrEvil == "good")
                    {
                        goodOrEvil = "Savior of the seven realms";
                        LordsInfo lordsInfo = new LordsInfo(lordName, goodOrEvil, startingZone);
                        lordsInfoUse.NewLord(lordsInfo);
                    }
                    else if (goodOrEvil == "evil")
                    {
                        goodOrEvil = "Destroyer of the seven realms";
                        LordsInfo lordsInfo = new LordsInfo(lordName, goodOrEvil, startingZone);
                        lordsInfoUse.NewLord(lordsInfo);
                    }
                }
               
            }
            return "Lords Added" + csvFilePath;
        }
               
    }
}

