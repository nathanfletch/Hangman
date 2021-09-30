using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hangman.Models;
using System;
using System.Collections.Generic;

namespace Hangman.Tests
{
  
  [TestClass]
  public class GuessTests: IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void Guess_ReturnsInstanceOfGuess_True()
    {
      //arrange
      
      Guess testGuess = new Guess("i");
      
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual(typeof(Guess), testGuess.GetType());
    }
    [TestMethod]
    public void Constructor_AssignsLetterProperty_i()
    {
      Guess testGuess = new Guess("i");
      // any necessary logic to prep for test; instantiating new classes, etc.
      Assert.AreEqual("i", testGuess.Letter);
    }
  }
}