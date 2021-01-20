using System;
using System.Text.RegularExpressions;

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


            /* Exercise 2 Instructions
             *  • Update your variable to ask the user for their social security number, store their input into a string
                variable
                • Display only the first digits of their SSN
                • Display only the last four digits of their SSN
                • Display the whole SSN removing all dashes and replacing all but the last four digits with the * symbol
            */

            // Starting a new variable
            string ssn = "";
            string replace;

            // Ask user's SSN and store input
            while (string.IsNullOrEmpty(ssn)) // repeats until the user enters something
                                              // TODO does not check for length or other factors in this exercise
            {
                Console.WriteLine("\nWhat is your Social Security Number?");
                ssn = Console.ReadLine();
                ssn = ssn.Trim(); // get rid of spaces at front and last

            }

            // Display first 3 digits
            Console.WriteLine(ssn.Substring(0, 3));

            // Display last 4 digits
            Console.WriteLine(ssn.Substring(ssn.Length - 4, 4));

            // remove all dashes and replace all numbers with *
            replace = ssn;
            replace = replace.Replace("-", "");
            replace = Regex.Replace(replace, "[0-9]", "*");
            Console.WriteLine(replace);

        }
    }
}
