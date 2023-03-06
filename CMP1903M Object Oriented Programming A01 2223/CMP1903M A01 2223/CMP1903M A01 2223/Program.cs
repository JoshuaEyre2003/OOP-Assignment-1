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
            Testing validation = new Testing();
            
            string input;
            string shuffleChoice;
            Pack.Deal();
            Console.WriteLine("Please enter an amount of cards(1,52)");
            input = Console.ReadLine();
            int intInput = validation.Validation(input,52,1,0);
            Console.WriteLine("Please enter an amount of cards(1,52)");
            shuffleChoice = Console.ReadLine();
            int intshuffleChoice = validation.Validation(shuffleChoice, 52, 1, 0);
            Pack.shuffleCardPack(intshuffleChoice);
            Pack.dealCard(intInput);
        }
    }
}
