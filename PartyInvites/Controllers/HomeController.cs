using Microsoft.AspNetCore.Mvc;
using System;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult  Index()
        {
            ViewBag.header = "My Index";
            return View("MyView");
            //return new RedirectResult("Home/StringStr");
            //return new UnauthorizedResult();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            //to do
            return View();
        }
    }
}
