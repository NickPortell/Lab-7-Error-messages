using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Build Specifications:
             * 1) Write a method that will validate names. Names can only have alphabets, 
                  they should start with a capital letter, and they have a maximum length of 30.

               2) Write a method that will validate emails. An email should be in the following 
                  format:{combination of alphanumeric characters, with a length between 5 and 30, 
                  and there are no special characters}@{combination of alphanumeric characters, with 
                  a length between 5 and 10, and there are no special characters}.{domain can be combination
                  of alphanumeric characters with a length of (2) or (3)}

               3) Write a method that will validate phone numbers. A phone number should be in the following
                  format:{area code of 3 digits)-{3 digits}-{4 digits}

               4) Write a method that will validate date based on the following format:{dd/mm/yyyy}

            Hint: Use https://regexr.com/

                Extended Challenges:
                -Write a method that validates HTML elements (Example: <p> </p> is a valid html element, and
                 <h1 <h1> is not valid. Dont worry about special cases where you have self-contained HTML elements
            */
            

            try
            {
                Console.Write("Please enter a valid Name: ");
                Console.WriteLine(GetName());
            }
            catch (Exception notName)
            {
                Console.WriteLine(notName.Message);
            }
            //catch ()
            //{

            //}
            //catch ()
            //{

            //}

        }
        // METHOD SPACE //


        public static string GetName()
        {
            string userInput;
            bool regexName, regexFullName;

            userInput = Console.ReadLine();
            regexFullName = Regex.IsMatch(userInput, @"(\b[A-Z][a-z]{1,30}\s[A-Z][a-z]{1,30}\b)");
            regexName = Regex.IsMatch(userInput, @"(\b[A-Z][a-z]{1,30}\b)");


            if (regexFullName)
            {
                Console.WriteLine("Name is valid!");
            }
            else if(regexName)
            {
                Console.WriteLine("Name is valid!");
            }
            else
            {
                throw new Exception("Sorry, name is not valid!");
            }
            return userInput;
        }


        public static string GetEmail() //NO Special characters {._-} etc.
        {
            string userInput;
            bool regexName;

            userInput = Console.ReadLine(); // {(5-30) alphanumerics} @ {(5-10) alphanumerics} . {(2-3) alphanumerics}
            regexName = Regex.IsMatch(userInput, @"([0-9a-zA-Z]{5,30})+(@)([0-9a-zA-Z]{5,10})(\.)([0-9a-zA-Z]){2,3}");

            if (regexName)
            {
                throw new Exception("Sorry, email is not valid!");
            }
            else
            {
                Console.WriteLine("Email is valid!");
            }
            return userInput;
        }


        public static string GetPhone()
        {
            string userInput;
            bool regexName;

            userInput = Console.ReadLine();
            regexName = Regex.IsMatch(userInput, "");

            if (regexName)
            {
                throw new Exception("Sorry, phone is not valid!");
            }
            else
            {
                Console.WriteLine("Phone is valid!");
            }
            return userInput;
        }

        public static string GetDate()
        {
            string userInput;
            bool regexName;

            userInput = Console.ReadLine();
            regexName = Regex.IsMatch(userInput, "");

            if (regexName)
            {
                throw new Exception("Sorry, date is not valid!");
            }
            else
            {
                Console.WriteLine("Date is Valid!");
            }
            return userInput;
        }

        public static string GetHTML()
        {
            string userInput;
            bool regexName;

            userInput = Console.ReadLine();
            regexName = Regex.IsMatch(userInput, "");

            if (regexName)
            {
                throw new Exception("Sorry, HTML is not valid!");
            }
            else
            {
                Console.WriteLine("HTML is valid!");
            }
            return userInput;
        }

    }
}
