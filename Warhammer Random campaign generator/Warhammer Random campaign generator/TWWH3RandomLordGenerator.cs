using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer_Random_campaign_generator
{
    public class TWWH3RandomLordGenerator
    {
        private LordCSVInsert lordCSVInsert = new LordCSVInsert();
        private LordInfoUse lordInfoUse = new LordInfoUse();        
        private List<LordsInfo> lordsList = new List<LordsInfo>();


        public void LordSelectMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Lord Select Menu");
            Console.WriteLine();
            Console.WriteLine(" (1) Select Random Lord");
            Console.WriteLine(" (2) Change Quantity of players");
            Console.WriteLine(" (3) Change Selection parameters");
            Console.WriteLine(" Please select menu option");
        }

        public void Run()
        {
            lordCSVInsert.InsertLords(lordInfoUse);

            bool keeprunning = true;

            while (keeprunning == true)
            {
                LordSelectMainMenu();
                string mainMenuSelection = Console.ReadLine();

                if (mainMenuSelection == "1" || mainMenuSelection == "2" || mainMenuSelection == "3")
                {
                    if (mainMenuSelection == "1")
                    {
                        //SelectRandomLord();
                    }

                    else if(mainMenuSelection == "2")
                    {
                        //ChangeQuantityOfPlayers();
                    }

                    else if (mainMenuSelection == "3")
                    {
                        //ChangeSelectionParameters();
                    }

                    else
                    {
                        Console.WriteLine("Please Select a menu option");
                        //SelectRandomLord();
                    }
                }
            }


        }
    }   
}
