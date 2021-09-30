
namespace Hangman.Models
{
  public class Guess 
  {
    public string Letter { get; set; }
    public bool InWord { get; set; }

    public Guess(string letter)
    {
      Letter = letter;
      // InWord = WordFunction();
      //leave it off at first, or call the parent's function here
    }

    //constructor

    //tests: type, property, adding to a list, id?

    //guess() -is that the constructor?
    //find
  }
}