using CHIRON.Models;
using Microsoft.AspNetCore.Mvc;

namespace CHIRON.Controllers
{
    public class SignsController : Controller
    {
        public IActionResult Index()
        {
            var repo = new SignRepository();
            var chironList = repo.ApiReturn();
            return View(chironList);
        }


        public IActionResult Aries_House_1()
        {
            return View();
        }

        public IActionResult Taurus_House_2()
        {
            return View();
        }

        public IActionResult Gemini_House_3()
        {
            return View();
        }

        public IActionResult Cancer_House_4()
        {
            return View();
        }

        public IActionResult Leo_House_5()
        {
            return View();
        }

        public IActionResult Virgo_House_6()
        {
            return View();
        }

        public IActionResult Libra_House_7()
        {
            return View();
        }

        public IActionResult Scorpio_House_8()
        {
            return View();
        }

        public IActionResult Sagittarius_House_9()
        {
            return View();
        }

        public IActionResult Capricorn_House_10()
        {
            return View();
        }

        public IActionResult Aquarius_House_11()
        {
            return View();
        }

        public IActionResult Pisces_House_12()
        {
            return View();
        }
    }
}
