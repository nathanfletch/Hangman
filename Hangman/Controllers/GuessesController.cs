using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;
using System;

namespace Hangman.Controllers
{
  public class GuessesController : Controller
  {
    // [HttpGet("/words/{id}/guesses/")]
    // public ActionResult Index(int id)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   //getAll 
    //   Word selectedWord = Word.Find(id);
    //   //all guesses - just the list of guesses for the word we're doing
    //   List<Guess> wordGuesses = selectedWord.Guesses;
    //   //make a dictionary - word object and all guesses - 
    //   model.Add("words", selectedWord);
    //   model.Add("guesses", wordGuesses);
      
    //   return View(model);
    //   // new guess logic here
    //   // creates new guess, determines guess success, adds guess to used-letters list(!new! put this in)
    // }
    [HttpGet("/words/{id}/guesses/new")]
    public ActionResult New(int id)
    {
      
      //submit the model, pass it
      Word selectedWord = Word.Find(id);
      return View(selectedWord);
    }

    
  }
}

/*
Vendor - types of vendors? myStore - just holds order?
Orders - 
StoreItem -


*/