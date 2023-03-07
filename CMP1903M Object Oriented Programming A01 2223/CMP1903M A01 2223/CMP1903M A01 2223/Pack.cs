using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {

        public static List<Card> pack = new List<Card>();
        public static List<Card> shuffled = new List<Card>();
        public static Random random = new Random();
        public Pack()
        {
            for (int t = 1;t < 5; t++)
            {
                for (int n = 1; n < 14; n++)
                {
                    Card card = new Card();
                    card.Value = n;card.Suit = t;
                    pack.Add(card);
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 3)
            {
                Console.WriteLine("No shuffle has been applied");
                return false;
            }
            if (typeOfShuffle == 1)
            {
                
                
                for (int i = 0;i < 52; i++)
                {
                    int randomNum = random.Next(0, pack.Count);
                    shuffled.Add(pack[randomNum]);
                    pack.RemoveAt(randomNum);
                }
                pack = shuffled;
                Console.WriteLine("The Fisher-Yates shuffle has been applied");
                return true;
            }
            if(typeOfShuffle == 2)
            {
                
                
                for (int i = 0; i < 26; i++)
                {
                    shuffled.Add(pack[0]);
                    pack.RemoveAt(0);
                }
                List<Card> riffled = new List<Card>();
                for (int i = 0;i < 26; i++)
                {
                    riffled.Add(shuffled[i]);
                    riffled.Add(pack[i]);
                }
                pack = riffled;
                Console.WriteLine("The riffle shuffle has been applied");
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public static Card Deal()
        {
            
            int randomNum = random.Next(0, 53);
            Card card = pack[randomNum];
            Console.WriteLine($"Your card is: {card.Suit} {card.Value}");
            return card ;

        }
        public static List<Card> dealCard(int amount)
        {
            List<Card> cards = new List<Card>();
            for(int i = 0; i < amount; i++)
            {
                cards.Add(pack[i]);
                
            }
            foreach (Card card in cards)
            {
                Console.WriteLine($"Card : {card.Suit} {card.Value}");
            }
            return cards;
        }
    }
}
