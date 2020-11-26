using System;

namespace Game
{
    /// <summary>
    ///  The abstract CardGames class 
    ///  contains the basic functionality of all games which has cards
    /// </summary>
    public abstract class CardGames{
        public Player Player;
        public abstract bool PlayACard();
        public abstract void RestartGame();
        public abstract void ShuffleTheCards();
        
        /// <summary>
        /// This method is used to check whether a player has cards or not
        /// </summary>
        /// <returns>Returns True if player has cards</returns> 
        public bool PlayerHasCards()
        {
            return ( this.Player.Cards.Count == 0)? true:false;
        }

        /// <summary>
        /// This method is used to end the game 
        /// </summary>
        public void EndTheGame()
        {
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Remaining cards with you "+ this.Player.Cards.Count+ "\n");
            Console.WriteLine("_________________ The End ____________________________"); 
            this.Player.Cards.Clear();
        }    
    }
}