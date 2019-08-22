// Name: ASPNET Lab02
// Author: James Smelser
// Date: August 20, 2019
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            if (hour < 12)
                ViewBag.Greeting = "Good Morning";
            else if (hour >= 12 && hour < 18)
                ViewBag.Greeting = "Good Afternoon";
            else
                ViewBag.Greeting = "Good Evening";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        { 
             if (ModelState.IsValid) 
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            } 
            else 
            {
    
                return View();
            }
        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}
