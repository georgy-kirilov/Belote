namespace Belote
{
    using System.Collections.Generic;

    public enum CardValue
    {
        Two,
        Three,
        Four,
        Five,
        Six,
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
                { CardValue.Two, "2" },
                { CardValue.Three, "3" },
                { CardValue.Four, "4" },
                { CardValue.Five, "5" },
                { CardValue.Six, "6" },
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