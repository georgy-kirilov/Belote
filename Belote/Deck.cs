namespace Belote
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Deck
    {
        private readonly IGameDrawer _gameDrawer;
        private readonly ICollection<Card> _cards = new HashSet<Card>();

        public Deck(IGameDrawer gameDrawer)
        {
            _gameDrawer = gameDrawer;
            Initialize();
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
    }
}
