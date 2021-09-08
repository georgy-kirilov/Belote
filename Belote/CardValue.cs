namespace Belote
{
    using System.Collections.Generic;

    public enum CardValue
    {
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace,
    }

    public static class CardValueExtension
    {
        public static string StringValue(this CardValue cardValue)
        {
            var cardValueStrings = new Dictionary<CardValue, string>
            {
                { CardValue.Seven, "7" },
                { CardValue.Eight, "8" },
                { CardValue.Nine, "9" },
                { CardValue.Ten, "10" },
                { CardValue.Jack, "J" },
                { CardValue.Queen, "Q" },
                { CardValue.King, "K" },
                { CardValue.Ace, "A" },
            };

            return cardValueStrings[cardValue];
        }
    }
}