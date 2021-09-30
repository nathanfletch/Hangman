// multiple collections in a list (type of guess) Player1 guesses Words
//   word constructor - List _allWords - won/lost bool prop
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Word
  {
    public string Letters {get; set;}
    public bool Survived {get;set;}
    public int Attempts {get;set;}
    public int Id {get;}
    public List<Guess> Guesses = new List<Guess>(){
    };
    //cat - list of item 

    private static List<Word> _usedWords = new List<Word>();
    private static List<string> _potentialWords = new List<string>(4){"hello","world","foo","bar"};
    //constructor - pull a word from the list
  public Word()
  {
    _usedWords.Add(this);
    Id = _usedWords.Count;
    Letters = _potentialWords[Id - 1];
    Attempts = Letters.Length + 2;
    Survived = true;
  }

  public static void ClearAll()
  {
    _usedWords.Clear();
  }
    // logic for repeat letters or not a problem?

    // public bool IsCorrectGuess()
    // {

    // }
    //getall

    //clearall

    //find

    //get
  }
}