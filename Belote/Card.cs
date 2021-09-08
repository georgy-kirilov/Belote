namespace Belote
{
    using System;

    public class Card
    {
        private readonly IGameDrawer _gameDrawer;

        public Card(CardValue value, CardSuit suit, IGameDrawer gameDrawer)
        {
            Value = value;
            Suit = suit;
            _gameDrawer = gameDrawer;
        }

        public int Points { get; set; }

        public CardSuit Suit { get; }

        public CardValue Value { get; }

        public void Draw()
        {
            _gameDrawer.DrawCard(this);
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Card)
            {
                Card other = obj as Card;
                return Suit == other.Suit && Value == other.Value;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Suit, Value);
        }
    }
}
