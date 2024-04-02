using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using OOP_PROJECT;
using OOP_PROJECT.Main_Character_Description;

namespace OOP_PROJECT.Places
{
    internal class MainStore : Place
    {
        internal override string Description()
        {
            return @"STORE
1. Fruits, regenarates 5 hp - 10 gold
2. Super fruits, regerates 20 hp - 40 gold
3. Chocolate bar - more resistance in the forest - 2 seconds of invulneravility - 20 gold 
4. 50/50 chance 
5. go back to refugee


What option do you pick(write the number)?";

 
        }
        internal override void MovingAround(string choice2)
        {
            switch (choice2)
            {
                case "1":                   
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    Game.Transition<Refugee>();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
            
        }
        static int GoldReturn()
        {
            
            return 0;
        }
    }
}
