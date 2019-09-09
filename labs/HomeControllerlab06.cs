// Name: ASPNET lab06
// Author: James Smelser
// Date: August 29, 2019
using Microsoft.AspNetCore.Mvc;
using WorkingWithVisualStudio1.Models;
using System.Linq;

namespace WorkingWithVisualStudio1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(SimpleRepository.SharedRepository.Products.Where(p => p?.Price < 50));
        }
    }
}
