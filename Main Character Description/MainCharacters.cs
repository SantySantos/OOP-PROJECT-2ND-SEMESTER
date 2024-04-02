using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_PROJECT.Story
{
    internal class MaleCharacters : Characters
    {
        public override string Name { get; set; } = "Kairos";
        public override double hp { get; set; } = 120;
        public override int gold { get; set; } = 100;
        public override double agility { get; set; } = 80;
        public override int armor { get; set; } = 60;
        public override int speed { get; set; } = 40;
        public void GeneralMaleDescription()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hello, I am {this.Name}");
            Console.WriteLine($"HP: {this.hp}");
            Console.WriteLine($"Gold : {this.gold}");
            Console.WriteLine($"Agility: {this.agility}");
            Console.WriteLine($"Armor: {this.armor}");
            Console.WriteLine($"Speed: {this.speed} ");   
        }
    }
    internal class FemaleCharacters : Characters
    {
        public override string Name { get; set; } = "Aria";
        public override double hp { get; set; } = 100;
        public override int gold { get ; set ; } = 100;
        public override double agility { get; set; } = 100;
        public override int armor { get; set; } = 40;
        public override int speed { get; set; } = 60;
        public void GeneralFemaleDescription()
        {
            Console.WriteLine();         
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Hello, I am {this.Name}");
            Console.WriteLine($"HP: {this.hp}");
            Console.WriteLine($"Gold : {this.gold}");
            Console.WriteLine($"Agility: {this.agility}");
            Console.WriteLine($"Armor: {this.armor}");
            Console.WriteLine($"Speed: {this.speed} ");
            
        }
    }
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
            if (choice == "b")
            {
                MaleCharacters FinalCharacter = new MaleCharacters();
                ChooseTrue();
            }
            else if (choice == "c")
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
