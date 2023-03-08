using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        public static List<Card> pack = new List<Card>();//Creates a list ready for the 52 cards to be created
        public static List<Card> shuffled = new List<Card>();// creates a second empty list which will be used in the shuffling of the deck
        public static Random random = new Random();//Create a random object so that it is more efficent then instantiating a new one everytime a random number is needed within a procedure
        public Pack()
        {
            
            //This will generate the 52 cards needed for the shuffles by looping 4 times for the suits and 13 times for values of the cards
            for (int t = 1;t < 5; t++)//Loops for the 4 different suits
            {
                for (int n = 1; n < 14; n++)//Loops for the 13 values of cards needed per suit
                {
                    Card card = new Card();//Creates a new card object
                    card.Value = n;card.Suit = t;//Assigns both a suit and value the card
                    pack.Add(card);//Adds a card to the deck
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //This will use the users shuffle choice to then select a type of shuffle and perform said shuffle the options are no shuffle,fisher-yates and
            //riffle which all have there own algorithems within this function
            
            
            if (typeOfShuffle == 3)//uses the users shuffle choice to select what type of shuffle to perform
            {
                //This will perform no shuffle leaving the cards in the original order going from 1 1 to 4 13 in order
                Console.WriteLine("No shuffle has been applied");//Tells the user what has happened within this shuffle
                return false;//returns false due to no shuffle
            }
            if (typeOfShuffle == 1)//uses the users shuffle choice to select what type of shuffle to perform
            {
                //The Fisher-Yates shuffle Takes cards at random and adds them to a new deck allow for all the cards to be randomised throughout the new deck this is
                //different to the riffle shuffle because there is no patter
                
                for (int i = 0;i < 52; i++)//loops for all 52 of the cards to allow for a maximised shuffle
                {
                    int randomNum = random.Next(0, pack.Count);// uses the random object created earlier to make a random int between 0 and the number of objects left within the list
                    shuffled.Add(pack[randomNum]);//adds the selected card to the empty shuffle list
                    pack.RemoveAt(randomNum);//removes card that was added to shuffle list to stop duplicates
                }
                pack = shuffled;//Makes pack the shuffled pack to allow for the procedures later on when dealing the cards to access the pack
                Console.WriteLine("The Fisher-Yates shuffle has been applied");//Tells the user what has happened within this shuffle
                return true;//return true since a shuffle has been applied
            }
            if(typeOfShuffle == 2)//uses the users shuffle choice to select what type of shuffle to perform
            {
                
                //Peforms a riffle shuffle which is where the deck is split inn half and added back one at a time to a total deck meaning
                //that the deck should alternate between the lowest and middle range upwards from the cards
                
                for (int i = 0; i < 26; i++)//loops for half of the total cards
                {
                    shuffled.Add(pack[0]);//adds the first card in the pack to shuffled to allow for the first half to be seprated from the total deck
                    pack.RemoveAt(0);//removes that same half from the pack to stop duplication
                }
                List<Card> riffled = new List<Card>();//new list has been made for the cards so that they can be added back in, with the alternating fashion needed for the riffle shuffle
                for (int i = 0;i < 26; i++)//loops for half the total number of cards in a deck
                {
                    riffled.Add(shuffled[i]);//adds one of the card from the first half
                    riffled.Add(pack[i]);//adds one card from the second half
                }
                pack = riffled;//Makes pack the riffled pack to allow for the procedures later on when dealing the cards to access the pack
                Console.WriteLine("The riffle shuffle has been applied");//Tells the user what has happened within this shuffle
                return true;//return true since a shuffle has been applied
            }
            else//to allow for all paths to have a return function for the code
            {
                return false;//returns false
            }
            

        }
        public static Card Deal()
        {
            //This will output a singluar card, selected at random from the deck asif it had been shuffle or randomised at the beginning of a game
            //This could then be used for games such as blackjack or poker if it were to be implemented

            Console.WriteLine("First Card:");
            Card card = pack[0];//creates a card object and gives it the values of that random card
            Console.WriteLine($"Your card is: {card.Suit} {card.Value}");//outputs the cards suit and value for the user
            return card ;//returns the card object incase it is needed within the testing class

        }
        public static List<Card> dealCard(int amount)
        {
            //This will output a certain amount of the cards that the user will request when the function is called in a different class
            
            List<Card> cards = new List<Card>();//Creates a new lift for the cards to be transfered into incase they were to be used for a game in future development
            
            for(int i = 0; i < amount; i++)//loops for the number of cards the user wants to deal
            {
                cards.Add(pack[i]);//adds the selected card to a list incase a game were to be created in the future using this deal function
                Console.WriteLine($"Card:{pack[i].Suit} {pack[i].Value}");//outputs the cards suit and value for the user
                
                
            }
            
            return cards;//returns the cards dealt to the player
        }
    }
}
