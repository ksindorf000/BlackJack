using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Deck
    {
        public static List<Cards> CreateBikeList()
        {
            var deck = new List<Cards>();
            var rng = new Random();

            for (int i = 0; i < 52; i++)
            {
                CreateCards(deck, rng);
            }

            return deck;
        }

        private static void CreateCards(List<Cards> deck, Random rng)
        {
            int value = rng.Next(1, 11);
            string name;

            deck.Add(new Cards(value, name));

        }
    }
}
