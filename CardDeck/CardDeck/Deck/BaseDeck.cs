using System;
using System.Collections.Generic;
using CardDeck.Suit;
using CardDeck.Number;

namespace CardDeck.Decks
{
    public class BaseDeck
    {
        private List<Card> deck;
        private BaseSuit _suits;
        private BaseNumber _numbers;
        private static Random random;

        public BaseDeck(BaseSuit selectedSuits, BaseNumber selectedNumbers)
        {
            random = new Random();
            deck = new List<Card>();
            _suits = selectedSuits;
            _numbers = selectedNumbers;
            InitializeDeck();
        }

        private void InitializeDeck()
        { 
            string[] numbers = _numbers.getNumbers();
            string[] suits = _suits.getSuits();

            for(int i = 0; i < suits.Length; i++)
            {
                for(int j = 0; j < numbers.Length; j++)
                {
                    deck.Add(new Card(suits[i], numbers[j]));
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            //Fisher-Yates shuffle
            int n = deck.Count;
            while(n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }   
        }

        public Card DrawCard()
        {
            //remove a card from the deck
            Shuffle();
            Card card = deck[deck.Count-1];
            deck.RemoveAt(deck.Count-1);
            return card;
           
            //Random rand = new Random();
            //int num = rand.Next(_deck.Count);
            //var randomCard = _deck[num];
            //_deck.RemoveAt(num);
            //return randomCard;
        }

        public List<Card> GetDeck()
        {
            return deck;
        }

    }
}