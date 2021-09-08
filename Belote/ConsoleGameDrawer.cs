namespace Belote
{
    using System;

    public class ConsoleGameDrawer : IGameDrawer
    {
        public const int CardWidth = 5;
        public const ConsoleColor CardBackgroundColor = ConsoleColor.White;

        public void DrawCard(Card card)
        {
            string suitAsString = card.Suit.StringValue();
            string valueAsString = card.Value.StringValue();

            var color = card.Suit == CardSuit.Spades || card.Suit == CardSuit.Clubs ? ConsoleColor.Black : ConsoleColor.Red;

            string topRow = valueAsString.PadRight(CardWidth);
            string bottomRow = valueAsString.PadLeft(CardWidth);
            string middleRowPadding = new(' ', CardWidth / 2);
            string middleRow = $"{middleRowPadding}{suitAsString}{middleRowPadding}";

            Console.ForegroundColor = color;

            DrawCardRow(topRow);
            DrawCardRow(middleRow);
            DrawCardRow(bottomRow);
        }

        private static void DrawCardRow(string rowValue, ConsoleColor cardBackgroundColor = CardBackgroundColor)
        {
            var consoleBackgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = cardBackgroundColor;
            Console.Write(rowValue);
            Console.BackgroundColor = consoleBackgroundColor;
            Console.WriteLine();
        }
    }
}
