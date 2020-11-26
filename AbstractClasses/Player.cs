using System.Collections.Generic;

namespace Game
{
    /// <summary>
    ///  This abstract class is used to store 
    ///  the player details in the game
    /// </summary>
    public abstract class Player
    {
       public string Name;
       public Queue<ICard> Cards;
    }
}
