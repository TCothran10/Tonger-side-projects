using System;
using System.Collections.Generic;
using System.Text;

namespace Warhammer_Random_campaign_generator 
{
    public class Random_Lord_Selector
    {

        private readonly Random randomizer = new Random();

        public static void Main()
        {
            Lords lords = new Lords();
            List<string> lordChoices = lords.MainList();


            Console.WriteLine("Please hit enter to Select a random Lord!");
            Console.ReadLine();

            Random rnd = new Random();           
            
            int index = rnd.Next(lordChoices.Count);
            Console.WriteLine(lordChoices[index]); 

            
        }
    }


}


