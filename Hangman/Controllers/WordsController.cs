using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

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
    [HttpGet("/words/{id}")]
    public ActionResult Show(int id)
    {
      //find
      Word selectedWord = Word.Find(id);
      return View(selectedWord);
    }
    //like categories - showing all words - all games (results?) - create a word (get a word to start the game)
  }
}