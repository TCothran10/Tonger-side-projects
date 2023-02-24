using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Warhammer_Random_campaign_generator
{
    public class LordCSVInsert
    {

        public string InsertLords(LordsInfo info)
        {
            string csvFilePath = @"C:\Users\Student\Tonger - side - projects\Warhammer Random campaign generator";

            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                while(!reader.EndOfStream)
                {
                    string lordInfo = reader.ReadLine();

                    string[] lordBreakdown = lordInfo.Split("|");

                    string lordName = lordBreakdown[0];
                    string goodOrEvil = lordBreakdown[1];
                    int startingZone = int.Parse(lordBreakdown[2]);
                }
            }
            return "Lords Added" + csvFilePath;
        }
    }
}
