using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace RNG
{
    public class TWWH3RandomLordGenerator
    {
        private LordCSVInsert lordCSVInsert = new LordCSVInsert();        
        private List<LordsInfo> lordsList = new List<LordsInfo>();
        private ListManager lordInfoUse = new ListManager();
        private string SaviorOrBlight = "both";

        public void PlayerCountSelect()
        {
            Console.WriteLine("Please select Number of players (1-4)" );            
        }
        public void ApplicationTitle()
        {

            Console.WriteLine("\r\n░██╗░░░░░░░██╗░█████╗░██████╗░██╗░░██╗░█████╗░███╗░░░███╗███╗░░░███╗███████╗██████╗░  ██╗██╗██╗\r\n░██║░░██╗░░██║██╔══██╗██╔══██╗██║░░██║██╔══██╗████╗░████║████╗░████║██╔════╝██╔══██╗  ██║██║██║\r\n░╚██╗████╗██╔╝███████║██████╔╝███████║███████║██╔████╔██║██╔████╔██║█████╗░░██████╔╝  ██║██║██║\r\n░░████╔═████║░██╔══██║██╔══██╗██╔══██║██╔══██║██║╚██╔╝██║██║╚██╔╝██║██╔══╝░░██╔══██╗  ██║██║██║\r\n░░╚██╔╝░╚██╔╝░██║░░██║██║░░██║██║░░██║██║░░██║██║░╚═╝░██║██║░╚═╝░██║███████╗██║░░██║  ██║██║██║\r\n░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═╝╚═╝╚═╝\r\n\r\n██╗░░░░░░█████╗░██████╗░██████╗░  ░██████╗███████╗██╗░░░░░███████╗░█████╗░████████╗░█████╗░██████╗░\r\n██║░░░░░██╔══██╗██╔══██╗██╔══██╗  ██╔════╝██╔════╝██║░░░░░██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗\r\n██║░░░░░██║░░██║██████╔╝██║░░██║  ╚█████╗░█████╗░░██║░░░░░█████╗░░██║░░╚═╝░░░██║░░░██║░░██║██████╔╝\r\n██║░░░░░██║░░██║██╔══██╗██║░░██║  ░╚═══██╗██╔══╝░░██║░░░░░██╔══╝░░██║░░██╗░░░██║░░░██║░░██║██╔══██╗\r\n███████╗╚█████╔╝██║░░██║██████╔╝  ██████╔╝███████╗███████╗███████╗╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║\r\n╚══════╝░╚════╝░╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚══════╝╚══════╝╚══════╝░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
        }
        public void LordSelectMainMenu()
        {
            
            
            //ToDo: Add parameters to the Random lord selection (So all parameters are handeled in that menu, elimiating the need for redundant menus)
            
            Console.WriteLine();
            Console.WriteLine("\r\n█░░ █▀█ █▀█ █▀▄   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█\r\n█▄▄ █▄█ █▀▄ █▄▀   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █░▀░█ ██▄ █░▀█ █▄█");
            Console.WriteLine();
            Console.WriteLine(" \r\n▄▀ ▄█ ▀▄   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀█ ▄▀█ █▄░█ █▀▄ █▀█ █▀▄▀█   █░░ █▀█ █▀█ █▀▄\r\n▀▄ ░█ ▄▀   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █▀▄ █▀█ █░▀█ █▄▀ █▄█ █░▀░█   █▄▄ █▄█ █▀▄ █▄▀");
            Console.WriteLine("\r\n▄▀ ▀█ ▀▄   █▀▀ █░█ ▄▀█ █▄░█ █▀▀ █▀▀   █▀█ ▄▀█ █▀█ ▄▀█ █▀▄▀█ █▀▀ ▀█▀ █▀▀ █▀█ █▀\r\n▀▄ █▄ ▄▀   █▄▄ █▀█ █▀█ █░▀█ █▄█ ██▄   █▀▀ █▀█ █▀▄ █▀█ █░▀░█ ██▄ ░█░ ██▄ █▀▄ ▄█");           
            Console.WriteLine(" \r\n█▀█ █░░ █▀▀ ▄▀█ █▀ █▀▀   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█   █▀█ █▀█ ▀█▀ █ █▀█ █▄░█\r\n█▀▀ █▄▄ ██▄ █▀█ ▄█ ██▄   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █░▀░█ ██▄ █░▀█ █▄█   █▄█ █▀▀ ░█░ █ █▄█ █░▀█");
        }

        public void Run()
        {
            ApplicationTitle();

            lordCSVInsert.InsertLords(lordInfoUse);

            bool keeprunning = true;

            PlayerCountSelect();
            int playerSelectCount = Int32.Parse(Console.ReadLine());
           

            while (keeprunning == true)
            {
                LordSelectMainMenu();

                string mainMenuSelection = Console.ReadLine();

                if (mainMenuSelection == "1" || mainMenuSelection == "2")
                {
                    if (mainMenuSelection == "1")
                    {
                       SelectRandomLord(playerSelectCount);
                    }

                    else if (mainMenuSelection == "2")
                    {
                       SaviorOrBlight = ChangeParameters();
                       
                    }                    

                    else
                    {
                        Console.WriteLine("Please Select a menu option");
                        SelectRandomLord(playerSelectCount);
                    }
                }
            }
        }
        public string ChangeParameters()
        {
            Console.WriteLine("Would you like to Play as a Savior or Blight of the seven realms");
            Console.WriteLine("(1) Savior");
            Console.WriteLine("(2) Blight");            
            string goodOrEvilChange = Console.ReadLine();

            if (goodOrEvilChange == "1" || goodOrEvilChange == "2")
            {
                if (goodOrEvilChange == "1")
                {
                    return "Savior ";
                }
                if (goodOrEvilChange == "2")
                {
                    return "Blight ";
                }               
            }
            return "Invalid choice ";            
        }

        private void SelectRandomLord(int numberOfPlayers)
        {
            Random R = new Random();
            
            try
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("|         Lord Name          |           Savior or Blight          | Starting Zone |");
                Console.WriteLine();
                int Count = 1;

                while (Count <= numberOfPlayers)
                {
                    if (SaviorOrBlight == "both")
                    {


                    }
                    else if (SaviorOrBlight == "Savior")
                    {
                        
                    }
                    else if (SaviorOrBlight == "Blight")
                    {
                        foreach (LordsInfo lords in lordInfoUse.AllLords)
                        {
                            // TODO Check the property for "goodorevil" in "lords" element for "blight"

                            // TODO If lord is a blight lord, then add that element to the new array for blight lords

                            // TODO Select blight lord from new array (in a similar way you are currently selecting lords)
                        }
                    }

                    int index = R.Next(0, lordInfoUse.AllLords.Count());
                    LordsInfo lord = lordInfoUse.AllLords[index];
                    if (numberOfPlayers >= 5 || numberOfPlayers <= 0)
                    {
                        Console.WriteLine("Invalid Player selection please select valid player count");
                        Run();
                    }
                    else if (lord.IsAvailable)
                    {
                        
                        Console.Write(lord.LordName.PadRight(34));
                        Console.Write(lord.GoodOrEvil.PadRight(37));
                        Console.Write(lord.StartingZone);
                        Console.WriteLine();
                        Console.WriteLine();

                        Count++;
                        lord.IsAvailable = false;
                    }

                    
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Problem reading data: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Data file provided is in incorrect format" + ex.Message);
            }      
       

        }

    }
}
