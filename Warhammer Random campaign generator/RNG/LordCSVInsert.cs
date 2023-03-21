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
        //This class is where we read the "Lords.csv" file and import the data
        //the information is then broken down into individual pieces letting them be read  and utilized


        public string InsertLords(ListManager manager)
        {
            System.IO.File.ReadAllText("Lords.csv");

            using ( StreamReader reader = new StreamReader("Lords.Csv"))
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
                        manager.NewLord(lordsInfo);
                    }
                    else if (goodOrEvil == "evil")
                    {
                        goodOrEvil = "Blight of the seven realms";
                        LordsInfo lordsInfo = new LordsInfo(lordName, goodOrEvil, startingZone);
                        manager.NewLord(lordsInfo);
                    }
                }
               
            }
            return "Lords Added";
        }
               
    }
}

