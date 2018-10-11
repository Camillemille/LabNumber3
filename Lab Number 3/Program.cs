using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue; //Varible has to be delcared outside the loop because it is being used it outside the loop.  
            do
            {
                Console.WriteLine("Enter an integer between 1 and 100"); //Prompts the user to enter a integer.
                string userInput = Console.ReadLine(); //Declaring a string called userInput whose value is determind by the user.
                int userNumber = int.Parse(userInput); //Created an integer and called it userNumber. Converted the string into an integer using the parse function. 
                if (userNumber % 2 == 1) //Checks for odd numbers
                {
                    if (userNumber < 60) // Checks that the userNumber is less than 60. 
                    {
                        Console.WriteLine("Odd {0}", userNumber);
                    }

                }

                else
                {
                    if (userNumber >= 2 && userNumber < 25) //If the number does not meet the above parameters this runs
                                                            //If the user number is greater than or equal to two and less than 25 it will run
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                }
                if (userNumber % 4 == 2) // Checks if the userNumber is even.
                {

                    if (userNumber >= 26 && userNumber < 60) // checks if the userNumber is greater than or equal to 26 and less than 60.
                    {

                        Console.WriteLine("Even");
                    }
                }



                if (userNumber % 4 == 2) 
                {
                    if (userNumber > 60)
                    {
                        Console.WriteLine("Even {0}", userNumber);
                    }
                }
                if (userNumber % 2 == 1)
                {
                    if (userNumber > 60)
                    {
                        Console.WriteLine("Odd {0}", userNumber);
                    }
                }



                Console.WriteLine("Would you like to Continue?");
                Continue = Console.ReadLine().ToLower(); //Value is assgined before the while loop checks it. 

            } while(Continue == "yes" || Continue == "y"); /*This makes it so that even if the user types in an 
                                                            uppercase "Y" it will still ask to continue.*/ 
            Console.WriteLine("Okay, Bye!"); // Ends the program. 
             
        }
    }
}
