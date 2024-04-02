using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_PROJECT.Story
{

    internal class ChoosingCharacter
    {
        static bool IsChosen;
        internal bool ChoosingChar() => IsChosen;
        internal static void ChooseTrue()
        {
            IsChosen = true;
        }

        MaleCharacters characterMale = new MaleCharacters();
        FemaleCharacters characterFemale = new FemaleCharacters();
        public void CharacterDescription()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"Please choose your character
[A] See characteristics
[B] select Kairos
[C] Select Aira");
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Choose a character"); 
        }

        public void CharacterSelect(string choice) 
        {
            
            switch (choice)
            {
                case "a":
                    characterMale.GeneralMaleDescription();
                    Console.ResetColor();
                    characterFemale.GeneralFemaleDescription();
                    Console.ReadKey();
                    Console.Clear();
                    CharacterDescription();
                    break;
                case "b":
                    characterMale.GeneralMaleDescription();
                    FinalCharacter(choice);                   
                    break;
                case "c":
                    characterFemale.GeneralFemaleDescription();
                    FinalCharacter(choice);
                    break;
                default:
                    Console.WriteLine("you have chosen an invalid option");
                    break;
            }
            Console.ReadKey();
            Console.Clear();
            
        }
        public void FinalCharacter(string choice)
        {            
            if(choice == "b")
            {
                MaleCharacters FinalCharacter = new MaleCharacters();
                ChooseTrue();
            }
            else if(choice == "c")
            {
                FemaleCharacters FinalCharacter = new FemaleCharacters();
                ChooseTrue();
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
            }
        }
    }
}
