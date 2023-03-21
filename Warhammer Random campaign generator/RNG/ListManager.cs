using System;
using System.Collections.Generic;
using System.Text;

namespace RNG
{
    //Creates the lists that hold the infor on the lords
    public class ListManager
    {
        public List<LordsInfo> lordsList = new List<LordsInfo>();

        public IList<LordsInfo> AllLords
        {
            get
            {
                return lordsList.ToArray();
            }
        }
        //Adds the lords to the list and if there are no lords to add will throw an exception.
        //until "lords.csv" is unavalible or missing this will function. if this ever throws check csv integrity
        public void NewLord(LordsInfo lord)
        {
            if (lord == null)
            {
                throw new ArgumentException("No Lord Present");
            }
            lordsList.Add(lord);
        }
        //Checks to make sure the lords in the lords list are accurately adding
        public LordsInfo GetLordInfo(string lordName)
        {
            foreach (LordsInfo lord in lordsList)
            {
                if (lord.LordName == lordName)
                {
                    return lord;
                }
            }
            return null;
        }
    }
}
