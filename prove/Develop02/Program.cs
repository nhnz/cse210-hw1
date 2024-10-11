using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using System.Threading;


class Program
{
    static void Main(string[] args)
    { 
        Journal theJournal = new Journal();                            
        PromptGenerator promptGenerator = new PromptGenerator();       
        
        // Set the file path
        Console.Write("Enter the path to save/load your journal file: ");
        string filePath = Console.ReadLine();
        theJournal.SetFilePath(filePath);
        
        //menu user will choose from
        while (true)
        {
            Console.WriteLine("\n---Welcome to the Journal Manu---");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Clear all journal text");
            Console.WriteLine("6. Exit");
            Console.Write("what would you like to do?, Choose an option: ");
            
            string choice = Console.ReadLine();                        

            switch (choice)
            {
                //Random prompt
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");

                    //Capture user response
                    string response = Console.ReadLine();              
                    
                    //Create a new entry
                    //Add the entry to the journal.
                    Entry newEntry = new Entry(prompt, response);     
                    theJournal.AddEntry(newEntry);                   
                    break;
                
                //Display all entries in the journal
                case "2":
                    theJournal.DisplayAll();                          
                    break;

                case "3":
                    //save the journal to the file.
                    theJournal.SaveToFile();                  
                    break;

                case "4":
                    //Load journal from file
                    theJournal.LoadFromFile();                
                    break;

                case "5":
                    //Clear Journal
                    theJournal.ClearEntries();
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("===========\nJournal is empty you can start afresh adding text\n==========");
                    ForegroundColor = ConsoleColor.White;

                    break;

                case "6":
                    ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("===============\nGoodbye!\n==============="); 
                    ForegroundColor = ConsoleColor.White;
                    return;                                           //Exit the program

                default:
                    ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("========\nInvalid option. Please try again.\n========");
                    ForegroundColor = ConsoleColor.White;
                    break;

            }
            

        }

    }
}
    

    



