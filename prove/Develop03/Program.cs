using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var scriptures = new List <Scripture>
        {
            new Scripture( "John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in Him shall not perish but have eternal life"),
            new Scripture("Proverbs 3:5-6","Trust in the Lord with all your heart and lean not on your own understanding; in all your ways acknowledge him; and he will make your paths straight.")
        };

        var random = new Random();
        var currentScripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture);
            Console.WriteLine("\nPress Enter to hide words or type quit to exit.");

            var input = Console.ReadLine();
            if (input?.ToLower() == "quit")
            break;

            //hides on random word
            currentScripture.HideRandomWord();
            if(currentScripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are now hidden.");
                break;
            }
        }
    }
}