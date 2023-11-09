using System;

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

                    Console.WriteLine("Hola, this is the task tracker.");
                    Console.WriteLine();

                    Console.WriteLine("Input the first name please");
                    string storeName = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter in a second name, we are planning to create a loop here");
                    string storeName2 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter in a third name");
                    string storeName3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter in a fourth name");
                    string storeName4 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Enter in a fifth name");
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
                        Console.WriteLine($"{i+1}: {namesArray[i]}");
                    }

                    Console.WriteLine();
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




                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Lets go again");
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                
                case 3:
                    Console.WriteLine("Yay. you picked list's creating, storing and looping");


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