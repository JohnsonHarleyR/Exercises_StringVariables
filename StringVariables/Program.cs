using System;

namespace StringVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercise 1 instructions
             Create a string variable to store a message to the user asking them for their full name
             Use the variable to ask the user for their full name and store the user's input in a different variable
             Display their name with all letters as upper case and remove any empty spaces on the right of their input
             Display their name with all letters as lower case and remove any empty spaces on the left of the input
             Display the length of their name as they entered it but removing any empty space on either side of the input.
             Display the location of the first space in their name, ignoring spaces on either side of the input
             Display the location of the last space in their name, ignoring spaces on either side of the input */

            // Variables
            string fullName = "";

            // Ask user's name and store input
            while (string.IsNullOrEmpty(fullName)) // repeats until the user enters something
            {
                Console.WriteLine("What is your full name?");
                fullName = Console.ReadLine();
            }

            // Display name with letters in upper case and remove spaces at end
            Console.WriteLine(fullName.ToUpper().TrimEnd());

            // Display name with letters in lower case and remove spaces at start
            Console.WriteLine(fullName.ToLower().TrimStart());

            // Display length of name without spaces on start or end
            Console.WriteLine(fullName.Trim().Length);

            // Display location of first space, not counting those at the start and end
            Console.WriteLine($"Index of first space: {fullName.Trim().IndexOf(" ")}");

            // Display location of last space, not counting those at the start and end
            Console.WriteLine($"Index of last space: {fullName.Trim().LastIndexOf(" ")}");

        }
    }
}
