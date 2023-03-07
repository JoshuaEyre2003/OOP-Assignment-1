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


            Pack.Deal();
            

            Shuffle(pack, validation);

            Deal(validation);

            Console.ReadKey();
        }
        public static void Shuffle(Pack pack, Program validation)
        {
            string shuffleChoice;
            Console.WriteLine("Please Enter either 1 2 or 3 for the type of shuffle\n 1 is fisher-yates shuffle\n 2 is Riffle shuffle \n 3 is no Shuffle");
            shuffleChoice = Console.ReadLine();
            int intshuffleChoice = validation.Validation(shuffleChoice, 3, 1, 0);
            Pack.shuffleCardPack(intshuffleChoice);
        }
        public static void Deal(Program Validation)
        {
            string input;
            Console.WriteLine("Please enter an amount of cards(1,52)");
            input = Console.ReadLine();
            int intInput = Validation.Validation(input, 52, 1, 0);
            List<Card> cards = Pack.dealCard(intInput);
            
            
        }
        



        
    }
}
