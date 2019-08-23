using System;
using Microsoft.AspNetCore.Mvc;
using ParkFinder.Models;

namespace ParkFinder.Controllers
{
    public class ParksController : Controller
    {
        public IActionResult Index()
        {
            var allParks = Park.GetAllParksAsync();
            return View(allParks);
        }
    }
}