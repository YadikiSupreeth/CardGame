
namespace Game
{
    /// <summary>
    ///  This is a custom Exception class which is used  
    ///  to throw if the user enters the invalid option
    /// </summary>
    public class InValidGameOptionException : System.Exception
    { 
        string message;
        // Constrcutor overloading
        public InValidGameOptionException() { }
        public InValidGameOptionException(string message) : base(message) { }

        public override string ToString()
        {
            return "_________________________________________________________\n"+this.message+"_________________________________________________________\n";
        }
    }
}