
using System.Collections.Generic;
using Game;
using System.Linq;
using System;

namespace Game
{
    /// <summary>
    ///  This class is used to store 
    ///  the DeckCard details
    /// </summary>
    public class DeckCard:ICard
    {
        public int FaceValue {get; set;}
        public string FaceName {get; set;}        
        public DeckCardRules.Suit Suit {get;set;}

        /// <summary> 
        /// This method implements the PrintCardDetails function
        /// to print the details of the DeckCard
        /// </summary>
        public void PrintCardDetails()
        {
            Console.WriteLine("DeckCard=> FaceName "+this.FaceName+", Suit "+this.Suit);
        }
    }
}