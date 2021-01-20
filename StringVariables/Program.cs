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
            string message = "What is your full name?";

            // Ask user's name and store input
            while (string.IsNullOrEmpty(fullName)) // repeats until the user enters something
            {
                Console.WriteLine(message);
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

            // update message
            message = "\nWhat is your Social Security Number?";

            // Ask user's SSN and store input
            while (string.IsNullOrEmpty(ssn)) // repeats until the user enters something
                                              // TODO does not check for length or other factors in this exercise
            {
                Console.WriteLine(message);
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


            /* Exercise 3 Instructions
             *  • Update your variable to tell the user that you are going to help them create a password and ask
                them to enter any phrase
                • Store that word in a string variable
                • Ask the user to enter any number greater than 9, store that input in a string variable
                • Create a variable to store the password
                • Use the following requirements to create the password
                    o Remove any spaces from the input
                    o Replace the letter a with the number 2
                    o Replace the letter o with the number 0
                    o Replace the letter i with an exclamation mark
                    o Add the last digit of the number to the beginning of the password
                    o Add the first digit of the number to the end of the password
                • In a single message, use string interpolation to display the original phrase, number, and the newly
                created password to the user
            */

            // variables
            string phrase;
            string password;
            int number = 0;

            // update message and display
            message = "\nWe are now going to create a password.\nPlease enter any phrase:";
            Console.WriteLine(message);

            // get input for the phrase - TODO not using checks this time since it's just an exercise
            phrase = Console.ReadLine();
            password = phrase; // copy phrase to password to preserve the original

            while (number < 10) // makes sure it's more than 9, that's the only check I'm using for this exercise
            {
                // get the number
                message = "Please enter a number greater than 0:";
                Console.WriteLine(message);

                // get the input - TODO no check on the number so the program will throw an exception if they try
                // I could use a try catch and a loop - or a tryParse - maybe create methods to validate
                number = int.Parse(Console.ReadLine());
            }

            // remove any spaces
            password = password.Replace(" ", "");

            // replace the letter a with the number 2
            password =  password.Replace("a", "2");

            // replace the letter o with 0
            password =  password.Replace("o,", "0");

            // replace the letter i with !
            password =  password.Replace("i", "!");

            // put second digit of number at begging
            password =  password = number.ToString().Substring(number.ToString().Length - 1, 1) + password +
                number.ToString().Substring(0, 1);

            // display everything
            Console.WriteLine($"Phrase entered: {phrase}\nNumber entered: {number}\nNew Password:{password}");





        }
    }
}
