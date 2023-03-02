using System;
using System.Collections.Generic;
using System.Text;

namespace RNG
{
    public class LordInfoUse
    {
        private readonly List<LordsInfo> lordsList = new List<LordsInfo>();

        public IEnumerable<LordsInfo> LordsLists
        {
            get
            {
                return lordsList.ToArray();
            }
        }

        public void NewLord(LordsInfo lord)
        {
            if (lord == null)
            {
                throw new ArgumentException("No Lord Present");
            }
            lordsList.Add(lord);
        }

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
