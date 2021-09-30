using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System;
using System.Collections.Generic;

namespace Hangman.Tests
{
  
  [TestClass]
  public class WordTests: IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void Word_ReturnsInstanceOfWord_True()
    {
      //arrange
      Word testWord = new Word();
      
      //assert
      Assert.AreEqual(typeof(Word), testWord.GetType());
    }
    [TestMethod]
    public void Word_AssignsLettersFromWordList_True()
    {
      //arrange
      Word testWord = new Word();

      //act
      string result = testWord.Letters;

      //assert
      Assert.AreEqual(result, "hello");
    }
    [TestMethod]
    public void Word_AssignsAttemptsBasedOnWord_True()
    {
      //arrange
      Word testWord = new Word();

      //act
      int result = testWord.Attempts;
      
      //assert
      Assert.AreEqual(result, 7);
    }
    [TestMethod]
    public void Word_AssignsIdToWord_True()
    {
      //arrange
      Word testWord = new Word();

      //act
      int result = testWord.Id;
      
      //assert
      Assert.AreEqual(result, 1);
      
    }
    [TestMethod]
    public void Word_DetermineValidGuess_True()
    {
      //arrange
      Word testWord = new Word();
      Guess guess = new Guess("h");
      
      //act
      bool result = testWord.IsCorrectGuess(guess);
      
      //assert
      Assert.AreEqual(result, true);
    }
    [TestMethod]
    public void Word_DetermineInvalidGuess_True()
    {
      //arrange
      Word testWord = new Word();
      Word testWord2 = new Word();
      Guess guess = new Guess("h");
      
      //act
      bool result = testWord2.IsCorrectGuess(guess);
      
      //assert
      Assert.AreEqual(result, false);
    }
    [TestMethod]
    public void Word_AddsGuessToList_True()
    {
      //arrange
      Word testWord = new Word();
      Guess guess = new Guess("h");
      testWord.Guesses.Add(guess);
      testWord.IsCorrectGuess(guess);
      //act
      bool result = testWord.Guesses[0].InWord;
      
      //assert
      Assert.AreEqual(true, result);
    }
    [TestMethod]
    public void WordDisplay_ReturnsGuessedCharacters_h()
    {
      //arrange
      Word testWord = new Word();
      Guess guess = new Guess("h");
      testWord.Guesses.Add(guess);
      string expected = "h----";
      //act
      string result = testWord.WordDisplay();

      //assert
      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void WordDisplay_ReturnsGuessedCharacters_hello()
    {
      //arrange
      Word testWord = new Word();
      Guess guess = new Guess("h");
      testWord.Guesses.Add(guess);
      Guess guess2 = new Guess("e");
      testWord.Guesses.Add(guess2);
      Guess guess3 = new Guess("l");
      testWord.Guesses.Add(guess3);
      Guess guess4 = new Guess("o");
      testWord.Guesses.Add(guess4);
      string expected = "hello";
      //act
      string result = testWord.WordDisplay();

      //assert
      Assert.AreEqual(expected, result);
    }
  }
}