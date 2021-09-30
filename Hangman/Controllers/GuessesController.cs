// using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class GuessesController : Controller
  {
    [HttpPost("/words/{id}/guesses/")]
    public ActionResult Index(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      //getAll 
      Word selectedWord = Word.Find(id);
      //all guesses - just the list of guesses for the word we're doing
      List<Guess> wordGuesses = selectedWord.Guesses;
      //make a dictionary - word object and all guesses - 
      model.Add("words", selectedWord);
      model.Add("guesses", wordGuesses);
      
      return View(model);
      // new guess logic here
      // creates new guess, determines guess success, adds guess to used-letters list(!new! put this in)
    }
  }
}