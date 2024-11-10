using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("a. Populate Dictionary");
            Console.WriteLine("b. Display Dictionary Contents");
            Console.WriteLine("c. Remove a Key");
            Console.WriteLine("d. Add a New Key and Value");
            Console.WriteLine("e. Add a Value to an Existing Key");
            Console.WriteLine("f. Sort the Keys");
            Console.WriteLine("q. Quit");
            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (choice)
            {
                case 'a':
                    Console.Write("Enter key: ");
                    string key = Console.ReadLine();
                    Console.Write("Enter value: ");
                    string value = Console.ReadLine();

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary[key] = new List<string> { value };
                    }
                    else
                    {
                        Console.WriteLine("Key already exists!");
                    }
                    break;

                case 'b':
                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + string.Join(", ", item.Value));
                    }
                    break;

                case 'c':
                    Console.Write("Enter key to remove: ");
                    string keyToRemove = Console.ReadLine();
                    if (dictionary.ContainsKey(keyToRemove))
                    {
                        dictionary.Remove(keyToRemove);
                        Console.WriteLine("Key removed.");
                    }
                    else
                    {
                        Console.WriteLine("Key not found.");
                    }
                    break;

                case 'd':
                    Console.Write("Enter new key: ");
                    string newKey = Console.ReadLine();
                    Console.Write("Enter new value: ");
                    string newValue = Console.ReadLine();

                    if (!dictionary.ContainsKey(newKey))
                    {
                        dictionary[newKey] = new List<string> { newValue };
                    }
                    else
                    {
                        Console.WriteLine("Key already exists!");
                    }
                    break;

                case 'e':
                    Console.Write("Enter key to add value to: ");
                    string existingKey = Console.ReadLine();
                    if (dictionary.ContainsKey(existingKey))
                    {
                        Console.Write("Enter value to add: ");
                        string addValue = Console.ReadLine();
                        dictionary[existingKey].Add(addValue);
                    }
                    else
                    {
                        Console.WriteLine("Key not found.");
                    }
                    break;

                case 'f':
                    var sortedKeys = new List<string>(dictionary.Keys);
                    sortedKeys.Sort();
                    foreach (string sortedKey in sortedKeys)
                    {
                        Console.WriteLine(sortedKey + ": " + string.Join(", ", dictionary[sortedKey]));
                    }
                    break;

                case 'q':
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}