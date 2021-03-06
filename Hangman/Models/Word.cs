// multiple collections in a list (type of guess) Player1 guesses Words
//   word constructor - List _allWords - won/lost bool prop
using System.Collections.Generic;
using System;

namespace Hangman.Models
{
  public class Word
  {
    public string Letters {get; set;}
    public string RevealedLetters {get; set;}
    public bool Survived {get;set;}
    public int Attempts {get;set;}
    public int Id {get;}
    public List<Guess> Guesses = new List<Guess>();
    //do we actually want a list of characters? 
    //are we benefitting from having a list of Guess objects in some other way?
    //MVC perspective: displaying one specific guess with its properties (like todolist item with description/pri)
    //cat - list of item 

    private static List<Word> _usedWords = new List<Word>();
    // private static List<string> _potentialWords = new List<string>(4){"hello","world","foo","bar"};
    //constructor - pull a word from the list
    public Word(string word)
    {
      _usedWords.Add(this);
      Id = _usedWords.Count;
      Letters = word;
      RevealedLetters = this.WordDisplay();
      Attempts = Letters.Length + 2;
      Survived = true;
    }

    public static void ClearAll()
    {
      _usedWords.Clear();
    }

    public static List<Word> GetAll()
    {
      return _usedWords;
    }

    public bool IsCorrectGuess(Guess currentGuess) //a method should only do one thing
    {
      // Guess guessedLetter = new Guess(letter); //create it in a controller?
      if (Letters.Contains(currentGuess.Letter))
      {
        currentGuess.InWord = true;
        return true;
      }
      else
      {
        currentGuess.InWord = false;
        return false;
      }
    }

    public string WordDisplay()
    {
      string gameWord = Letters;
      string displayString = "";

      //look at each letter in the correct word 
      //if the user has guessed it, add on display string at that index, else add -

      for(int index = 0; index < gameWord.Length; index++)
      {
        int startingLength = displayString.Length;
        for(int i = 0; i < Guesses.Count; i++)
        {
          if (Guesses[i].Letter == gameWord[index].ToString())
          {
            displayString += gameWord[index];
          }
        }
        //if the lenght is the same as it used to be
        if (displayString.Length == startingLength)
        {
          displayString += "-";
        }

      }
        return displayString;
    }
    // logic for repeat letters or not a problem?

    public static Word Find(int searchId)
    {
      return _usedWords[searchId - 1];
    }
    //find

    //get
  } // class
} // namespace