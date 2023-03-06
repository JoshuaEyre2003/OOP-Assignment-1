using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        public Testing()
        {
            Program validation = new Program();
            Pack pack = new Pack();


            Card card = Pack.Deal();
            Console.WriteLine($"Your card is: {card.Suit} {card.Value}");

            Shuffle(pack, validation);

            Deal(validation);

            Outputting(pack, validation);
        }
        public static void Shuffle(Pack pack, Program validation)
        {
            string shuffleChoice;
            Console.WriteLine("Please enter an amount of cards(1,3)");
            shuffleChoice = Console.ReadLine();
            int intshuffleChoice = validation.Validation(shuffleChoice, 3, 1, 0);
            pack.shuffleCardPack(intshuffleChoice);
        }
        public static void Deal(Program Validation)
        {
            string input;
            Console.WriteLine("Please enter an amount of cards(1,52)");
            input = Console.ReadLine();
            int intInput = Validation.Validation(input, 52, 1, 0);
            Pack.dealCard(intInput);
        }
        public static void Outputting(Pack pack, Program Validation)
        {
            string amount;
            Console.WriteLine("Please enter an amount of cards(1,52)");
            amount = Console.ReadLine();
            int intshuffleChoice = Validation.Validation(amount, 52, 1, 0);
        }



        
    }
}
