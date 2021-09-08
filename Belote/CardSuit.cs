namespace Belote
{
    using System.Collections.Generic;

    public enum CardSuit
    {
        Spades,
        Hearts,
        Diamonds,
        Clubs,
    }

    public static class CardSuitExtension
    {
        public static string StringValue(this CardSuit cardSuit)
        {
            var cardSuitStrings = new Dictionary<CardSuit, string>
            {
                { CardSuit.Spades, "♠" },
                { CardSuit.Hearts, "♥" },
                { CardSuit.Diamonds, "♦" },
                { CardSuit.Clubs, "♣" },
            };

            return cardSuitStrings[cardSuit];
        }
    }
}