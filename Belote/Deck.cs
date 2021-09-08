namespace Belote
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Deck
    {
        private readonly IGameDrawer _gameDrawer;
        private readonly List<Card> _cards = new();

        public Deck(IGameDrawer gameDrawer)
        {
            _gameDrawer = gameDrawer;
            Initialize();
            //Shuffle();
            Cut();
        }

        public IReadOnlyCollection<Card> Cards => _cards.ToList().AsReadOnly();

        public void Initialize()
        {
            _cards.Clear();

            CardSuit[] cardSuits = Enum.GetValues<CardSuit>();
            CardValue[] cardValues = Enum.GetValues<CardValue>();

            foreach (CardSuit suit in cardSuits)
            {
                foreach (CardValue value in cardValues)
                {
                    _cards.Add(new Card(value, suit, _gameDrawer));
                }
            }
        }

        public void Shuffle()
        {
            var random = new Random();

            for (int index = 0; index < _cards.Count; index++)
            {
                int newIndex = random.Next(_cards.Count);
                var temporary = _cards[index];
                _cards[index] = _cards[newIndex];
                _cards[newIndex] = temporary;
            }
        }

        public void Cut()
        {
            var random = new Random();
            int cuttingIndex = random.Next(_cards.Count / 5, _cards.Count / 5 * 4);

            for (int index = 0; index < cuttingIndex; index++)
            {
                _cards.Add(_cards[0]);
                _cards.RemoveAt(0);
            }
        }
    }
}
