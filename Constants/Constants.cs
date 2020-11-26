namespace Game
{
    /// <summary>
    ///  This class is used to store all the
    ///  constants required for the deck card game
    /// </summary>
    public class DeckCardRules
    {
        public const int  NoOfSuits = 4;
        public const int  NoOfCardsInEachSuit = 13;
        public enum Suit {Clubs, Hearts, Spades, Diamond};
        public const int TotalCards = NoOfSuits * NoOfCardsInEachSuit;
        public static string[] Rank= {"A","2","3","4","5","6","7","8","9","10","J","Q","K"};
    }

    /// <summary>
    ///  This class is used to store all the
    ///  constants required for the game
    /// </summary>
    public class GameRules
    {
        public enum UserOptions {PlayACard=1, ShuffleCards, RestartGame, ExitGame};
    }
}