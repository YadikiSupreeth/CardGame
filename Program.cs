using System;

namespace Game
{
    /// <summary>
    ///  This class is used the run the deckCardGame
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            bool playTime = true;
            string playerName="LeadSquared";
         
            GameRules.UserOptions userChoice;
            CardGames deckCardGame= new DeckCardGame(playerName); // Creates a new DeckCardGame with DeckCardPlayer having DeckCards with him
           
            Console.Clear();
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine("   Hello "+playerName+" Welcome to the card games world");
            Console.WriteLine("____________________________________________________________");
            Console.WriteLine(" You Have 4 options to play in this game ");
            Console.WriteLine("*********************************");
            Console.WriteLine("Enter 1 To Play a card");
            Console.WriteLine("Enter 2 To Shuffle your cards ");
            Console.WriteLine("Enter 3 To Restart your game ");
            Console.WriteLine("Enter 4 To Exit");
            Console.WriteLine("*******************************");
            try{
                    while(playTime)
                    {
                        userChoice =(GameRules.UserOptions)Convert.ToInt32(Console.ReadLine());  // Boxing the user input into enum type 

                        switch(userChoice)
                        {
                            case GameRules.UserOptions.PlayACard:  playTime=(deckCardGame.PlayACard())?true:false;
                            break;

                            case GameRules.UserOptions.ShuffleCards: deckCardGame.ShuffleTheCards();
                            break;
                            
                            case GameRules.UserOptions.RestartGame: deckCardGame.RestartGame();
                            break;
                            
                            case GameRules.UserOptions.ExitGame:
                            default:
                                deckCardGame.EndTheGame();
                                playTime = false;
                                throw new InValidGameOptionException("Invalid game option");
                        }
                    }
                }
            catch(InValidGameOptionException IVGOptionException) 
            {
                Console.WriteLine(IVGOptionException);
            }
            catch(Exception e) 
            {
                Console.WriteLine(e);
            }
        }
    }
}
