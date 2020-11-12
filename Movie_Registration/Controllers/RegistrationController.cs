using Microsoft.AspNetCore.Mvc;
using Movie_Registration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Registration.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult RegistrationForm()
        {
            return View();
        }

        public IActionResult RegisteredMovies(Movie movie)
        {

            if (ModelState.IsValid)
            {
                return View("RegisteredMovies", movie);
            }
            else
            {
                return View("RegistrationForm", movie);
            }
        }

    }
}
