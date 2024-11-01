using Bragon_Ball_c_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bragon_Ball_c_.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            CharacterModel goku = new CharacterModel("goku","volar", "Saiyajin", "https://i.pinimg.com/736x/57/ed/25/57ed25ccf5133bf3dfe5aa440a8273de.jpg");


            return View(goku);
        }
    }
}
