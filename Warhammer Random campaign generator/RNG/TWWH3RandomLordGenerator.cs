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
            //Todo: Add \ a prompt for player count before the main menu runs
            //ToDo: Make it so when one is pulled it is no longer able to be grabbed.
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

            while (keeprunning == true)
            {
                PlayerCountSelect();
                int playerSelectCount = Int32.Parse(Console.ReadLine());
                LordSelectMainMenu();
                
                
                string mainMenuSelection = Console.ReadLine();

                if (mainMenuSelection == "1" || mainMenuSelection == "2" || mainMenuSelection == "3")
                {
                    if (mainMenuSelection == "1")
                    {
                       SelectRandomLord1(playerSelectCount);
                    }

                    else if (mainMenuSelection == "2")
                    {
                        //ChangeQuantityOfPlayers();
                    }                    

                    else
                    {
                        Console.WriteLine("Please Select a menu option");
                        //SelectRandomLord();
                    }
                }
            }
        }

        private void SelectRandomLord1(int numberOfPlayers)
        {
            Random R = new Random();
            
            try
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("|         Lord Name          |           Good or Evil          | Starting Zone |");
                Console.WriteLine();
                int Count = 1;

                while (Count <= numberOfPlayers)
                {


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
