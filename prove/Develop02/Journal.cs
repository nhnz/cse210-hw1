using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static System.Console;
using System.Threading;
using System.Net;
using System.Security.Cryptography.X509Certificates;



public class Journal
{
    private string path;
    //A list to hold defined prompt
    public List<Entry> _entries = new List<Entry>();

    public void SetFilePath(string filePath)
    {
        path = filePath;
    }

    //Add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        {
            _entries.Add(newEntry);
        }
    }


    //Display all entries in the journal

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nNo entries in the Journal.\n");
            ForegroundColor = ConsoleColor.White;
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                ForegroundColor = ConsoleColor.DarkMagenta;
                entry.Display();
                ForegroundColor = ConsoleColor.White;
            }
        }
    }



    // Create and save text in journal text file.
  public void SaveToFile()
    {
        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("No file path specified. Please set a path first.");
            return;
        }

        try
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
                }
            }
            ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Journal saved to: {path}");
            ResetColor();
        }
        catch (Exception ex)
        {
            ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error saving journal: {ex.Message}");
            ResetColor();
        }
    }

    public void LoadFromFile()
    {
        if (string.IsNullOrEmpty(path))
        {
            Console.WriteLine("No file path specified. Please set a path first.");
            return;
        }

        if (File.Exists(path))
        {
            _entries.Clear(); // Clear existing entries
            using (StreamReader reader = File.OpenText(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new Entry(parts[1].Trim(), parts[2].Trim())
                        {
                            _date = parts[0].Trim()
                        };
                        _entries.Add(entry);
                        
                    }
                }
            }
            ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Journal loaded from: {path}");
            
            ResetColor();
        }
        else
        {
            ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("File does not exist.");
            ResetColor();
        }
    }

    public void ClearEntries()
    {
        _entries.Clear();
        Console.WriteLine("All entries cleared.");
        WaitForKey();
    }

    //press any key to carry on
    public void WaitForKey()
    {
        ForegroundColor = ConsoleColor.DarkGray;
        WriteLine("\nPress any key.........");
        ForegroundColor = ConsoleColor.White;
        ReadKey(true);
    }
}
