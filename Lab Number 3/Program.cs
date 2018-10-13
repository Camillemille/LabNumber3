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

                if (userNumber <= 0 || userNumber > 100)// Tells the program to run if the userNumber is less than or equal to 0 or userNumber is greater than 100.
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                }

                else if (userNumber % 2 == 1 && userNumber <= 60) //Gives the program another condition that if the number is odd and less than or equal to 60.
                {
                    Console.WriteLine("Odd {0}", userNumber);
                }

                else if (userNumber >= 2 && userNumber <= 25 && userNumber % 2 == 0)// Gives the program more specifications to follow.
                {
                    Console.WriteLine("Even and less than 25");
                }

                else if (userNumber >= 26 && userNumber <= 60 && userNumber % 2 == 0)
                {

                    Console.WriteLine("Even");
                }


                else if (userNumber % 2 == 0 && userNumber > 60) //userNumber has to be even and greater than 60 to run. 
                {
                    Console.WriteLine("Even {0}", userNumber);

                }

                else if (userNumber % 2 == 1 && userNumber > 60)
                {
                    Console.WriteLine("Odd {0}", userNumber);
                }

                do //Checking to make sure the user can only put in a y/n.
                {
                    Console.WriteLine("Would you like to Continue? (y/n)");
                    Continue = Console.ReadLine().ToLower(); //Value is assgined before the while loop checks it. 
                } while (Continue != "n" && Continue != "y");
            } while (Continue == "y"); 
                                                           
            Console.WriteLine("Okay, Bye!"); // End of the program. 

        }
    }
}
