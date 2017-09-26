using Class12Demo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class12Demo.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Movie movie = new Movie
            {
                Title = "Jurassic Park",
                ReleaseDate = 1993,
                Rating = "PG-13",
                RunTime = 127
            };

            return View(movie);
        }
    }
}
