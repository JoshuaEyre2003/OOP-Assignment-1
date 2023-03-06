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
            Testing program = new Testing();
            
        }
        public int Validation(string input, int maxLength, int minLength, int refinedinput)
        {

            bool validated = false;
            while (validated == false)
            {
                try
                {
                    refinedinput = Convert.ToInt32(input);
                    if (refinedinput >= minLength && refinedinput <= maxLength)
                    {
                        validated = true;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter a number within {maxLength} and {minLength},Try again");
                        input = Console.ReadLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a Correct type.Try again");
                    input = Console.ReadLine();
                }

            }

            return refinedinput;
        }

    }
}
