namespace Belote
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.OutputEncoding = Encoding.UTF8;

            var gameDrawer = new ConsoleGameDrawer();

            var deck = new Deck(gameDrawer);

            foreach (Card card in deck.Cards)
            {
                card.Draw();
                Console.WriteLine();
            }
        }
    }
}
