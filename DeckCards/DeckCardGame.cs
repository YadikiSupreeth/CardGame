using System;

namespace Game
{
    /// <summary>
    ///  The abstract CardGames class 
    ///  contains the basic functionality of all games which has cards
    /// </summary>
    public class DeckCardGame:CardGames
    {
        /// <summary>
        /// This constructor used to initialize the game object 
        /// with the player name and their initial deck of cards 
        /// </summary>
        /// <param name="playerName"> Any class which extends palyer</param>
        public DeckCardGame(string playerName)
        {
            this.Player =  new  DeckCardPlayer(playerName);
            this.Player.Cards=DeckCardsService.GetNewShuffleCards();
        }

        /// <summary> 
        /// This method is used play the top card from his deck of cards 
        /// </summary>
        /// <returns>Returns True if player succesfully plays a card</returns> 
        public override bool PlayACard()
        {
            if(PlayerHasCards())
            {
                Console.WriteLine("___________________________________________________________________");
                Console.WriteLine("OOPS!! You cannot play any more, you dont have sufficient cards!!  ");
                Console.WriteLine("___________________________________________________________________");
                return false;
            }
            ICard topCard = this.Player.Cards.Peek();
            Console.WriteLine("______________________________________________________");
            topCard.PrintCardDetails();
            this.Player.Cards.Dequeue();
            Console.WriteLine("Remaining cards with you "+  this.Player.Cards.Count+ "\n");
            Console.WriteLine("______________________________________________________");
            return true; 
        }

        /// <summary>This method is used to clear all the 
        ///  cards from a player and get the new deck of cards 
        /// </summary>
        public override void RestartGame()
        {
            this.Player.Cards.Clear();
            this.Player.Cards = DeckCardsService.GetNewShuffleCards();
            Console.WriteLine("______________________________________________________");
            Console.WriteLine(" Restarted the game and you have "+ this.Player.Cards.Count+ " cards\n");
            Console.WriteLine("______________________________________________________");
        }

        /// <summary> 
        /// This method is used shuffle the cards in between the game 
        /// </summary>
        public override void ShuffleTheCards()
        {
            this.Player.Cards = DeckCardsService.Shuffle( this.Player.Cards);
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("            Shuffled the cards successfully\n ");
            Console.WriteLine("______________________________________________________");
        }
    }
}
