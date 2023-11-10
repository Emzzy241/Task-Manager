using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // using a while loop so I keep running the task Manager until user enters Ctrl+c which will forcefully kill the application
        while(true)
        {
                // collecting 5 names

            Console.WriteLine("Hola, this is the task tracker.");
            Console.WriteLine();

            Console.WriteLine("How the App works: you can perform any of the Tasks below.");
            Console.WriteLine();
            Console.WriteLine("Enter:");
            Console.WriteLine("1. to perform array creating, storing and array looping");
            Console.WriteLine("2. to perform dictionary creating, storing and dictionary looping");
            Console.WriteLine("3. to perform list creating, storing and list looping");
            Console.WriteLine();
            string userAction = Console.ReadLine();
            int userActionInt = int.Parse(userAction);


            switch (userActionInt)
            {
                case 1:
                    Console.WriteLine("Yay. you picked array's creating, storing and looping");

                      // collecting 5 names

                    Console.WriteLine();

                    Console.WriteLine("Enter the first name");
                    string storeName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the second name");
                    string storeName2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the third name");
                    string storeName3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the fourth name");
                    string storeName4 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter the fifth name");
                    string storeName5 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    // Console.WriteLine("Array created, press enter to loop through array");

                    // storing them 5 names in a string array, remember that C# has array for different datatypes(e.g: string array, integer array, double array)

                    string[] namesArray = {storeName, storeName2, storeName3, storeName4, storeName5};

                    // Displaying the array of names to user

                    Console.WriteLine("Here is the Array of names you have been able to create and loop through. Attached to it is the array's item index number");
                    Console.WriteLine();
                    for (int i = 0; i < namesArray.Length; i++)
                    {
                        // Console.WriteLine("Here is the list of names from the array you created");
                        Console.WriteLine($"{i}: {namesArray[i]}");  // for Array's index number
                        // Console.WriteLine($"{i+1}: {namesArray[i]}");  // for Array's serial number

                    }

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Lets go again");
                    Console.WriteLine();
                    Console.WriteLine();

                    // Using a foreach loop now
                    // When I used the foreach loop, I didnt really like it because I couldn't display the index number for each.. So I pivotted to using forloop
                    // foreach (string item in namesArray)
                    // {
                    //     Console.WriteLine($"{item}");   
                    // }


                    // for (int i = 0; i < length; i++)
                    // {

                        
                    // }    

                    break;

                case 2:

                    Console.WriteLine("Yay. you picked dictionary's creating, storing and looping");

                    // collecting five names from user to store in dictionary
                    Console.WriteLine("Enter the first name");
                    string storeDictName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the second name");
                    string storeDictName2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the third name");
                    string storeDictName3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the fourth name");
                    string storeDictName4 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the fifth name");
                    string storeDictName5 = Console.ReadLine();
                    Console.WriteLine();


                    // creating the dictionary to store all this names collected from me user
                    Dictionary<int, string> NamesDict = new Dictionary<int, string>() {{1, storeDictName}, {2, storeDictName2}, {3, storeDictName3}, {4, storeDictName4}, {5, storeDictName5}};

                    Console.WriteLine("Here is the Dictionary of names you have been able to create and loop through. Attached to it is its index number");
                    Console.WriteLine();

                    // time to loop through the dictionary with a for and a foreach loop 
                    // KeyValuePair<TKey, TValue> is a new class we will be using to represent each Key-Value pair within the dictionary
                    
                    // The foreach loop
                    // foreach (KeyValuePair<int, string> name in NamesDict)
                    // {
                    //     Console.WriteLine($"{name.Key}. {name.Value}");
                    // }

                    // The forloop
                    for (int i = 0; i < NamesDict.Count; i++)
                    {
                        KeyValuePair<int, string> name = NamesDict.ElementAt(i);
                        Console.WriteLine($" {name.Key} {name.Value}");
                    }




                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Lets go again");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Yay. you picked list's creating, storing and looping");

                    // Collecting 5 names to store in my list for user
                    Console.WriteLine("Enter the first name");
                    string storeListName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the second name");
                    string storeListName2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    
                    Console.WriteLine("Enter the third name");
                    string storeListName3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the fourth name");
                    string storeListName4 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter the fifth name");
                    string storeListName5 = Console.ReadLine();

                    // Creating me list and storing me variables in it
                    List<string> NamesList = new List<string>() {storeListName, storeListName2, storeListName3, storeListName4, storeListName5};

                    Console.WriteLine("Here is the List of names you have been able to create and loop through. Attached to it is its index number");
                    Console.WriteLine();

                    // Time to loop through my list
                    // foreach loop
                    // foreach (string name in NamesList)
                    // {
                    //     Console.WriteLine($"{name}");
                        
                    // }
                    // forloop
                    for (int i = 0; i < NamesList.Count; i++)
                    {
                        Console.WriteLine($"{i}: {NamesList[i]}");
                    }


                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Lets go again");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("I am deeply sorry, I didnt get that. Please try again");



                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Lets go again");
                    Console.WriteLine();
                    Console.WriteLine();
                    Main();
                    break;
            }    

            Console.WriteLine();
        }

    }
}