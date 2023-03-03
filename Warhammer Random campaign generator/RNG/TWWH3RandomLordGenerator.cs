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
        private LordInfoUse lordInfoUse = new LordInfoUse();


        public void LordSelectMainMenu()
        {

            Console.WriteLine("\r\n░██╗░░░░░░░██╗░█████╗░██████╗░██╗░░██╗░█████╗░███╗░░░███╗███╗░░░███╗███████╗██████╗░  ██╗██╗██╗\r\n░██║░░██╗░░██║██╔══██╗██╔══██╗██║░░██║██╔══██╗████╗░████║████╗░████║██╔════╝██╔══██╗  ██║██║██║\r\n░╚██╗████╗██╔╝███████║██████╔╝███████║███████║██╔████╔██║██╔████╔██║█████╗░░██████╔╝  ██║██║██║\r\n░░████╔═████║░██╔══██║██╔══██╗██╔══██║██╔══██║██║╚██╔╝██║██║╚██╔╝██║██╔══╝░░██╔══██╗  ██║██║██║\r\n░░╚██╔╝░╚██╔╝░██║░░██║██║░░██║██║░░██║██║░░██║██║░╚═╝░██║██║░╚═╝░██║███████╗██║░░██║  ██║██║██║\r\n░░░╚═╝░░░╚═╝░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝  ╚═╝╚═╝╚═╝\r\n\r\n██╗░░░░░░█████╗░██████╗░██████╗░  ░██████╗███████╗██╗░░░░░███████╗░█████╗░████████╗░█████╗░██████╗░\r\n██║░░░░░██╔══██╗██╔══██╗██╔══██╗  ██╔════╝██╔════╝██║░░░░░██╔════╝██╔══██╗╚══██╔══╝██╔══██╗██╔══██╗\r\n██║░░░░░██║░░██║██████╔╝██║░░██║  ╚█████╗░█████╗░░██║░░░░░█████╗░░██║░░╚═╝░░░██║░░░██║░░██║██████╔╝\r\n██║░░░░░██║░░██║██╔══██╗██║░░██║  ░╚═══██╗██╔══╝░░██║░░░░░██╔══╝░░██║░░██╗░░░██║░░░██║░░██║██╔══██╗\r\n███████╗╚█████╔╝██║░░██║██████╔╝  ██████╔╝███████╗███████╗███████╗╚█████╔╝░░░██║░░░╚█████╔╝██║░░██║\r\n╚══════╝░╚════╝░╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚══════╝╚══════╝╚══════╝░╚════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝");
            Console.WriteLine();
            Console.WriteLine("\r\n█░░ █▀█ █▀█ █▀▄   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█\r\n█▄▄ █▄█ █▀▄ █▄▀   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █░▀░█ ██▄ █░▀█ █▄█");
            Console.WriteLine();
            Console.WriteLine(" \r\n▄▀ ▄█ ▀▄   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀█ ▄▀█ █▄░█ █▀▄ █▀█ █▀▄▀█   █░░ █▀█ █▀█ █▀▄\r\n▀▄ ░█ ▄▀   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █▀▄ █▀█ █░▀█ █▄▀ █▄█ █░▀░█   █▄▄ █▄█ █▀▄ █▄▀");
            Console.WriteLine(" \r\n▄▀ ▀█ ▀▄   █▀▀ █░█ ▄▀█ █▄░█ █▀▀ █▀▀   █▀█ █░█ ▄▀█ █▄░█ ▀█▀ █ ▀█▀ █▄█   █▀█ █▀▀   █▀█ █░░ ▄▀█ █▄█ █▀▀ █▀█ █▀\r\n▀▄ █▄ ▄▀   █▄▄ █▀█ █▀█ █░▀█ █▄█ ██▄   ▀▀█ █▄█ █▀█ █░▀█ ░█░ █ ░█░ ░█░   █▄█ █▀░   █▀▀ █▄▄ █▀█ ░█░ ██▄ █▀▄ ▄█");
            Console.WriteLine(" \r\n▄▀ ▀▄   █▀▀ █░█ ▄▀█ █▄░█ █▀▀ █▀▀   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀ █ █▀█ █▄░█   █▀█ ▄▀█ █▀█ ▄▀█ █▀▄▀█ ▀█▀ █▀▀ █▀█ █▀\r\n▀▄ ▄▀   █▄▄ █▀█ █▀█ █░▀█ █▄█ ██▄   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░ █ █▄█ █░▀█   █▀▀ █▀█ █▀▄ █▀█ █░▀░█ ░█░ ██▄ █▀▄ ▄█");
            Console.WriteLine(" \r\n█▀█ █░░ █▀▀ ▄▀█ █▀ █▀▀   █▀ █▀▀ █░░ █▀▀ █▀▀ ▀█▀   █▀▄▀█ █▀▀ █▄░█ █░█   █▀█ █▀█ ▀█▀ █ █▀█ █▄░█\r\n█▀▀ █▄▄ ██▄ █▀█ ▄█ ██▄   ▄█ ██▄ █▄▄ ██▄ █▄▄ ░█░   █░▀░█ ██▄ █░▀█ █▄█   █▄█ █▀▀ ░█░ █ █▄█ █░▀█");
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
                        SelectRandomLord();
                    }

                    else if (mainMenuSelection == "2")
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
        private void SelectRandomLord()
        {
            Random R = new Random();
            int someRandomNumber = R.Next(0, lordsList.Count());
            try
            {
                Console.WriteLine();

                Console.WriteLine("|         Lord Name          |           Good or Evil         | Starting Zone |");
                Console.WriteLine();



                foreach (LordsInfo lord in lordInfoUse.LordsLists)
                {
                    
                    Console.WriteLine();
                    Console.Write(lord.LordName.PadRight(30));
                    Console.Write(lord.GoodOrEvil.PadRight(40));
                    Console.Write(lord.StartingZone);
                    
                }

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
