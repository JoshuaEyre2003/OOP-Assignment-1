using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Testing program = new Testing();//creates the testing object that then runs the program and has access to the pack and card classes
            
        }
        public int Validation(string input, int maxLength, int minLength, int refinedinput)
        {
            //This will check the type and length of an input to help with user inputs and stop the program from crashing because of missinputs
            bool validated = false;//creates a bool to be used in the while loop this is encapsulated into this function to stop is being used else where
            while (validated == false)//starts the while loop using the formentioned bool
            {
                try//initiates a try catch to see if the input can be converted to an int
                {
                    refinedinput = Convert.ToInt32(input);//converts the string into an int if possible
                    if (refinedinput >= minLength && refinedinput <= maxLength)//performs a range check of the int to see if it is within a specified range
                    {
                        validated = true;//stops the while loop if the conditions are met
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number within {maxLength} and {minLength},Try again");//error message for the user so they know what to fix when reentering the input for the code
                        input = Console.ReadLine();//gets the new input that will be tested
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a Correct type.Try again");//specific error message for the user so they can correct the issue with there input
                    input = Console.ReadLine();//gets the new input that will be tested again
                }

            }

            return refinedinput;//returns the int type of the input once one is entered correctly
        }

    }
}
