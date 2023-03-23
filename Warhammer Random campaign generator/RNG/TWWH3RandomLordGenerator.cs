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
        // Direct connections to other classes allowing use of the contents of those classes
        
        private LordCSVInsert lordCSVInsert = new LordCSVInsert();        
        private List<LordsInfo> lordsList = new List<LordsInfo>();
        private ListManager lordInfoUse = new ListManager();
        private string SaviorOrBlight = "both";

        //what appears on the main menu to select players
        public void PlayerCountSelect()
        {
            Console.WriteLine("Please select Number of players (1-4)" );            
        }
        //What presents the text of "Warhammer III lord selector"
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
        // What hapens when F5 is hit. this is the order in which the user is prompted information and realistically acts almost as a main menu taking you from
        // One part of the application to the other.
        public void Run()
        {
            ApplicationTitle();

            lordCSVInsert.InsertLords(lordInfoUse);

            bool keeprunning = true;
            //This while loop is entered and once entered puts you into the main menu where the user input changes where in the application we are setting.

            PlayerCountSelect();
            int playerSelectCount = Int32.Parse(Console.ReadLine());
           


            while (keeprunning == true)
            {
                LordSelectMainMenu();

                string mainMenuSelection = Console.ReadLine();

                if (mainMenuSelection == "1" || mainMenuSelection == "2")
                {
                    // See "SelectRandomLord" for the use of this 
                    if (mainMenuSelection == "1")
                    {
                       SelectRandomLord(playerSelectCount);
                    }

                    else if (mainMenuSelection == "2")
                    {
                       //SaviorOrBlight = ChangeParameters();
                       
                    }                    

                    else
                    {
                        Console.WriteLine("Please Select a menu option");
                        SelectRandomLord(playerSelectCount);
                    }
                }
            }
        }
        // This Is where the random generator is located, this finds the lords and prints them out in the console. this uses the Lords.csv file to find the lords and the 
        // "LordCSVInsert" breaks them down so they can be printed  as indipendent items.
 
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
