using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() { 
      return View(); 
    }
  }
}
/*
guesses property - int
guessed letters property - string

guess() - check duplicates

thing - guess myGuess.Character = 'r' .GuessNumber .IsInWord
collection - _guesse
multiple collections in a list (type of guess) Player1 guesses Words
  word constructor - List _allWords - won/lost bool prop
  
methods:
guess()
IsInWord()

thing = hangman Game

game {
  turns:
  word:
  player 1 {[]}
  player
}


b _ b b _ _
*/

// @{
//   @if (guess right)
//   {
//   layout=_RightLayout
//   }
//   else {
//     layout=_WrongLayout
//   }
// }