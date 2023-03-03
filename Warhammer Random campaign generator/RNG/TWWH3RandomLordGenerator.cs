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

        public void ApplicationTitle()
        {
            Console.WriteLine("\r\n░██╗░░░░░░░██╗░█████╗░██████╗░██╗░░██╗░█████╗░███╗░░░███╗███╗░░░███╗███████╗██████╗░  ██╗██╗██╗\r\n░██║░░██╗░░██║██╔══██╗██╔══██╗██║░░██║██╔══██╗████╗░████║████╗░████║██╔════╝██╔══██╗  ██║██║██║\r\n░╚██╗████╗██╔╝███████║██████╔╝███████║███████║██╔████╔██║██╔████╔██║█████╗░░██████╔╝  ██║██║██║\r\n░░████╔═████║░██╔══██║██╔══██╗██╔══██║██╔══██║██║╚██╔╝██║██║╚██╔╝██║██╔══╝░░██╔══██╗  ██║██║██║\r\n░░╚██╔╝░╚██╔╝░██║░░██║██║░░██║██║░░██║██║░░██║██║░╚═╝░██║██║░╚═╝░██║███████╗██║░░██║  ██║██║██║\r\n░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═╝╚═╝╚═╝\r\n\r\n██╗░░░░░░█████╗░██████╗░██████╗░  ░██████╗███████╗██╗░░░░░███████╗░█████╗░████████╗░█████╗░██████╗░\r\n██║░░░░░██╔══██╗██╔══██╗██╔══██╗  ██╔════╝██╔════╝██║░░░░░██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗\r\n██║░░░░░██║░░██║██████╔╝██║░░██║  ╚█████╗░█████╗░░██║░░░░░█████╗░░██║░░╚═╝░░░██║░░░██║░░██║██████╔╝\r\n██║░░░░░██║░░██║██╔══██╗██║░░██║  ░╚═══██╗██╔══╝░░██║░░░░░██╔══╝░░██║░░██╗░░░██║░░░██║░░██║██╔══██╗\r\n███████╗╚█████╔╝██║░░██║██████╔╝  ██████╔╝███████╗███████╗███████╗╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║\r\n╚══════╝░╚════╝░╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚══════╝╚══════╝╚══════╝░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
        }
        public void LordSelectMainMenu()
        {
            //Todo: Add  a prompt for player count before the main menu runs
            //ToDo: Add parameters to the Random lord selection (So all parameters are handeled in that menu, elimiating the need for redundant menus)
            
            Console.WriteLine();
            Console.WriteLine("\r\n█░░ █▀█ █▀█ █▀▄   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█\r\n█▄▄ █▄█ █▀▄ █▄▀   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █░▀░█ ██▄ █░▀█ █▄█");
            Console.WriteLine();
            Console.WriteLine(" \r\n▄▀ ▄█ ▀▄   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀█ ▄▀█ █▄░█ █▀▄ █▀█ █▀▄▀█   █░░ █▀█ █▀█ █▀▄\r\n▀▄ ░█ ▄▀   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █▀▄ █▀█ █░▀█ █▄▀ █▄█ █░▀░█   █▄▄ █▄█ █▀▄ █▄▀");
            Console.WriteLine(" \r\n▄▀ ▀█ ▀▄   █▀▀ █░█ ▄▀█ █▄░█ █▀▀ █▀▀   █▀█ █░█ ▄▀█ █▄░█ ▀█▀ █ ▀█▀ █▄█   █▀█ █▀▀   █▀█ █░░ ▄▀█ █▄█ █▀▀ █▀█ █▀\r\n▀▄ █▄ ▄▀   █▄▄ █▀█ █▀█ █░▀█ █▄█ ██▄   ▀▀█ █▄█ █▀█ █░▀█ ░█░ █ ░█░ ░█░   █▄█ █▀░   █▀▀ █▄▄ █▀█ ░█░ ██▄ █▀▄ ▄█");           
            Console.WriteLine(" \r\n█▀█ █░░ █▀▀ ▄▀█ █▀ █▀▀   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█   █▀█ █▀█ ▀█▀ █ █▀█ █▄░█\r\n█▀▀ █▄▄ ██▄ █▀█ ▄█ ██▄   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █░▀░█ ██▄ █░▀█ █▄█   █▄█ █▀▀ ░█░ █ █▄█ █░▀█");
        }

        public void Run()
        {
            ApplicationTitle();
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
                        SelectRandomLord();
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
        private void SelectRandomLord()
        {
            Random R = new Random();
            
            try
            {
                Console.WriteLine();

                Console.WriteLine("|         Lord Name          |           Good or Evil         | Starting Zone |");
                Console.WriteLine();

                int index = R.Next(0, lordInfoUse.AllLords.Count());
                LordsInfo lord = lordInfoUse.AllLords[index];
                
               
                

                    Console.WriteLine();
                    Console.Write(lord.LordName.PadRight(30));
                    Console.Write(lord.GoodOrEvil.PadRight(40));
                    Console.Write(lord.StartingZone);
                    
                

            }
            catch (IOException ex)
            {
                Console.WriteLine("Problem reading data: " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Data file provided is in incorrect format");
            }

        }

    }
}
