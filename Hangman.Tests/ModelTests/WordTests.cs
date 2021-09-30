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
  }
}