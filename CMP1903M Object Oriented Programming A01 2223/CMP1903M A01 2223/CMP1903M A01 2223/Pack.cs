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

        public Pack()
        {
            for (int t = 1;t <= 4; t++)
            {
                for (int n = 1; n < 14; n++)
                {
                    Card card = new Card();
                    card.Value = n;
                    card.Suit = t;
                    pack.Add(card);
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            if (typeOfShuffle == 0)
            {
                return false;
            }
            else if (typeOfShuffle == 1)
            {
                List<Card> shuffled = new List<Card>();
                Random random = new Random();
                for (int i = 0;i <= 51; i++)
                {
                    int randomNum = random.Next(0, pack.Count);
                    shuffled.Add(pack[randomNum]);
                    pack.RemoveAt(randomNum);
                }
                pack = shuffled;
                return true;
            }
            else if(typeOfShuffle == 2)
            {
                List<Card> shuffled = new List<Card>();
                List<Card> half = new List<Card>();
                for (int i = 0; i < 27; i++)
                {
                    half.Add(pack[i]);
                    pack.RemoveAt(i);
                }
                for (int i = 0;i < 27; i++)
                {
                    shuffled.Add(half[i]);
                    shuffled.Add(pack[i]);
                }
                return true;
            }
            else
            {
                return false;
            }
            

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
