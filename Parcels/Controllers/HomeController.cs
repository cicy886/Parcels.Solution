using Microsoft.AspNetCore.Mvc;

namespace Parcels.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}

// namespace Parcels.Controllers
// {
//   public class HomeController : Controller
//   {

//     [Route("/hello")]
//     public string Hello() { return "Hello friend!"; }

//     [Route("/goodbye")]
//     public string Goodbye() { return "Goodbye friend."; }

//     [Route("/")]
//     {
//       LetterVariable myLetterVariable = new LetterVariable();
//       myLetterVariable.Recipient = "Lina";
//       myLetterVariable.Sender = "Jasmine";
//       return View(myLetterVariable);
//     }

//     [Route("/form")]
//     public ActionResult Form() { return View(); }

//     [Route("/postcard")]
//     public ActionResult Postcard(string recipient, string sender)
//     {
//       LetterVariable myLetterVariable = new LetterVariable();
//       myLetterVariable.Recipient = recipient;
//       myLetterVariable.Sender = sender;
//       return View(myLetterVariable);
//     }
//   }
// }