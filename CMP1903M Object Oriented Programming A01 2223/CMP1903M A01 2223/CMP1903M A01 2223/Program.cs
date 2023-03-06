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
            Pack pack = new Pack();
            string input;
            Testing validation = new Testing();
            Console.WriteLine("Please enter an amount of cards(1,52)");
            input = Console.ReadLine();
            validation.Validation(input,52,1,0);
        }
    }
}
