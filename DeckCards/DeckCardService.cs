
using System.Collections.Generic;
using System.Linq;
using System;

namespace Game
{
    /// <summary>
    /// This class contains the general functionalities 
    /// required while playing a deckCard game
    /// </summary>
    public class DeckCardsService{
        /// <summary> 
        /// This method is used to create a new set of cards
        /// according to the game rules and returns, the shuffled of the same 
        /// </summary>
        public static Queue<ICard> GetNewShuffleCards()
        {
            Queue<ICard> cards = new Queue<ICard>();
            foreach(DeckCardRules.Suit suit in Enum.GetValues(typeof(DeckCardRules.Suit)))
            {
                for(int cardNumber=1; cardNumber <=DeckCardRules.NoOfCardsInEachSuit; cardNumber++)
                {
                    cards.Enqueue(new DeckCard()
                    {
                        Suit = suit,
                        FaceValue = cardNumber-1,
                        FaceName = DeckCardRules.Rank[cardNumber-1]
                    });
                }
            }
            return Shuffle(cards);
        }

        /// <summary>
        /// This method is used to shuffle the cards using Fisher-Yates Algorithm
        ///      Step 1: Randomly pick a card which has not been shuffled
        ///      Step 2: Swap the selected item with the last "unselected" card in the collection 
        /// </summary>
        /// <param name="unShuffleedCards"> Cards which needs to be shuffleed</param>
        public static Queue<ICard> Shuffle(Queue<ICard> unShuffledCards)
        {
            Queue<ICard> shuffledCards = new Queue<ICard>(); 
            Random random = new Random(DateTime.Now.Millisecond);
            List<ICard> unShuffledCardsList = unShuffledCards.ToList();

            if(unShuffledCardsList?.Count<=0) return shuffledCards; // Cannot shuffle empty deck of cards

            try{
                for (int lastUnShuffleedCardIndex = unShuffledCardsList.Count - 1; lastUnShuffleedCardIndex > 0; lastUnShuffleedCardIndex--)     
                {
                    int randomUnShuffleedCardIndex = random.Next(lastUnShuffleedCardIndex + 1); 

                    ICard temp = unShuffledCardsList[lastUnShuffleedCardIndex];              
                    unShuffledCardsList[lastUnShuffleedCardIndex] = unShuffledCardsList[randomUnShuffleedCardIndex];
                    unShuffledCardsList[randomUnShuffleedCardIndex] = temp;
                }
            }
            catch(IndexOutOfRangeException IORException)
            {
                Console.WriteLine("IndexOutOfRangeException caught: {0}", IORException);
            }
            foreach(var card in unShuffledCardsList)
            {
                shuffledCards.Enqueue(card);
            }

            return shuffledCards;
        }
    }
}
