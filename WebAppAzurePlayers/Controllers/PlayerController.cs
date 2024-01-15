using Microsoft.AspNetCore.Mvc;
using WebAppAzurePlayers.Models;

namespace WebAppAzurePlayers.Controllers
{
    public class PlayerController : Controller
    {
        static List<Player> players = new List<Player>()
        {
            new Player() {PId = 1,PName="Virat kohli",PCountry="RCB",PType="Batsman"},
             new Player() {PId = 2,PName="Rohith sharma",PCountry="DC",PType="Batsman"},
              new Player() {PId = 3,PName="siraj",PCountry="SRH",PType="Bowler"},
        };
        public IActionResult Index()
        {
            return View(players);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Player());
        }
        public IActionResult Create(Player play)
        {
            if(ModelState.IsValid)
            {
                players.Add(play);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
