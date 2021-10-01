using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/words")]
    public ActionResult Index() { 
      List<Word> allWords = Word.GetAll();
      // Word newWord = new Word();
      return View(allWords);
    }
    //goes to the empty form
    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }
    //submit handler from the form
    [HttpPost("/words/new")]
    public ActionResult Create(string newWord)
    {
      Word gameWord = new Word(newWord);

      return RedirectToAction("Index");
    }
    //doubles up as "index" for all guesses stored in this word
    [HttpGet("/words/{id}")]
    public ActionResult Show(int id)
    {
      //find
      Word selectedWord = Word.Find(id);
      return View(selectedWord);
    }

    [HttpPost("/words/{id}/guesses/")]
    public ActionResult Create(int wordId, string guessInput)
    {
      Console.WriteLine($"Word Id from a new guess form: {wordId}");
      Word selectedWord = Word.Find(wordId);
      Guess newGuess = new Guess(guessInput);
      selectedWord.Guesses.Add(newGuess);
      selectedWord.IsCorrectGuess(newGuess);
      
      return View("Show", selectedWord);
      // new guess logic here
      // creates new guess, determines guess success, adds guess to used-letters list(!new! put this in)
    }
  }
}