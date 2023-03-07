using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        //Class Testing was added to allow for the function of the program to run and be tested throughout development
        //This class will start by dealing one of the 52 cards before any shuffle has been applied
        //This class Creates a deck asks the user to select a shuffle then shuffles the cards accordingly then deals a specified amount out
        public Testing()
        {
            Program validation = new Program();//Creates a validation object to allow for inputs to be tested with a type and range check with appropriate outputs to match any issues
            Pack pack = new Pack();//creates a pack object which on creation creates a deck of 52 cards


            Pack.Deal();//deals one card from the pack, has been randomized asif pack was not sorted
            

            Shuffle(pack, validation);//Ask the user to select a shuffle then shuffles the cards accordingly

            Deal(validation);//Asks for an amount of cards to be dealt and will output the amount of cards

            Console.ReadKey();//Stops the program from closing before seeing all of the cards
        }
        public static void Shuffle(Pack pack, Program validation)
        {
            string shuffleChoice;//creats a string input so the validation can be carried out on the user input
            Console.WriteLine("Please Enter either 1 2 or 3 for the type of shuffle\n 1 is fisher-yates shuffle\n 2 is Riffle shuffle \n 3 is no Shuffle");//Asks user to select a type of shuffle
            shuffleChoice = Console.ReadLine();//geats the user input
            int intshuffleChoice = validation.Validation(shuffleChoice, 3, 1, 0);//Uses the validation class to check the type and range of the input
            Pack.shuffleCardPack(intshuffleChoice);//Uses the user input to select a style of shuffle either none, Fisher-Yates or riffle which all have different outcomes
        }
        public static void Deal(Program Validation)
        {
            string input;//creats a string input so the validation can be carried out on the user input
            Console.WriteLine("Please enter an amount of cards(1,52)");//Asks user to select a type of shuffle
            input = Console.ReadLine();//geats the user input
            int intInput = Validation.Validation(input, 52, 1, 0);//Uses the validation class to check the type and range of the input
            List<Card> cards = Pack.dealCard(intInput);//uses the input from before to output a desired number of cards
            
            
        }
        



        
    }
}
