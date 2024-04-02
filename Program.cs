using OOP_PROJECT;
using OOP_PROJECT.Places;
using OOP_PROJECT.Story;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;

internal class program
{
    static void Main(string[] args)
    {
        var game = new Game();
        game.Add(new Refugee());
        game.Add(new MainStore());
        game.Add(new Forest());
        game.Add(new Dungeon());
        
        ContextStory contextStory = new ContextStory();

        var choosingCharacters = new ChoosingCharacter();

        contextStory.Story();

        while (!choosingCharacters.ChoosingChar())
        {
           choosingCharacters.CharacterDescription();
           string choice = Console.ReadLine().ToLower() ?? "";
           game.Selection(choice);           
        }

       contextStory.FirstWhisper();

       while (!game.IsGameOver())
       {
            Console.WriteLine(game.CurrentPlaceDescription);
            string choice2 = Console.ReadLine().ToLower() ?? "";
            Console.Clear();
            game.MovingAround(choice2);
       }
       
    }
}
