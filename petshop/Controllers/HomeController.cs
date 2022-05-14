using Miau.DAL;
using Miau.Models;
using Miau.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Miau.Controllers
{
    public class HomeController : Controller
    {

        private AppDbContext _context;

       

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       

        public IActionResult Index()
        {
            var slider = _context.Sliders.FirstOrDefault();
            var sliderImages = _context.SliderImages.ToList();
            var service = _context.Service.FirstOrDefault();
            var serviceBox = _context.ServiceBoxes.FirstOrDefault();
            var serviceBox2 = _context.ServiceBoxes2.FirstOrDefault();
            var serviceBox3 = _context.ServiceBoxes3.FirstOrDefault();
            var about = _context.Abouts.FirstOrDefault();
            var aboutImages = _context.AboutImages.ToList();
            var adobt = _context.Adopts.FirstOrDefault();
            var comment = _context.Comments.FirstOrDefault();
            var ourTeam = _context.OurTeams.FirstOrDefault();
            var ourTeamImage1 = _context.OurTeamImage1.FirstOrDefault();
            var ourTeamImage2 = _context.OurTeamImage2.FirstOrDefault();
            var ourTeamImage3 = _context.OurTeamImage3.FirstOrDefault();
            var pat = _context.Pats.FirstOrDefault();

            return View(new HomeIndexViewModel { Slider = slider, 
                SliderImages = sliderImages,
                Services = service,
                ServiceBoxes = serviceBox, 
                ServiceBoxes2 = serviceBox2,
                ServiceBoxes3 = serviceBox3,
                Abouts = about,
                AboutImages = aboutImages,
                Adopts = adobt,
                Comments = comment,
                OurTeams = ourTeam,
                OurTeamImage1 = ourTeamImage1,
                OurTeamImage2 = ourTeamImage2,
                OurTeamImage3 = ourTeamImage3,
                Pats = pat


            });
        }
        public IActionResult About()
        {
            var about = _context.Abouts.FirstOrDefault();
            var aboutImages = _context.AboutImages.ToList();
            var adobt = _context.Adopts.FirstOrDefault();
            var comment = _context.Comments.FirstOrDefault();
            var ourTeam = _context.OurTeams.FirstOrDefault();
            var ourTeamImage1 = _context.OurTeamImage1.FirstOrDefault();
            var ourTeamImage2 = _context.OurTeamImage2.FirstOrDefault();
            var ourTeamImage3 = _context.OurTeamImage3.FirstOrDefault();
            var pat = _context.Pats.FirstOrDefault();



            return View(new AboutIndexViewModel
            {
                Abouts = about,
                AboutImages = aboutImages,
                Adopts = adobt,
                Comments = comment,
                OurTeams = ourTeam,
                OurTeamImage1 = ourTeamImage1,
                OurTeamImage2 = ourTeamImage2,
                OurTeamImage3 = ourTeamImage3,
                Pats = pat
            });
        }
        public IActionResult Blog()

        {

            return View();
        }
        public IActionResult Services()
        {
            var service = _context.Service.FirstOrDefault();
            var serviceBox = _context.ServiceBoxes.FirstOrDefault();
            var serviceBox2 = _context.ServiceBoxes2.FirstOrDefault();
            var serviceBox3 = _context.ServiceBoxes3.FirstOrDefault();
            var comment = _context.Comments.FirstOrDefault();
            var ourTeam = _context.OurTeams.FirstOrDefault();
            var ourTeamImage1 = _context.OurTeamImage1.FirstOrDefault();
            var ourTeamImage2 = _context.OurTeamImage2.FirstOrDefault();
            var ourTeamImage3 = _context.OurTeamImage3.FirstOrDefault();
            var pat = _context.Pats.FirstOrDefault();

            return View(new ServiceIndexViewModel
            {
                Services = service,
                ServiceBoxes = serviceBox,
                ServiceBoxes2 = serviceBox2,
                ServiceBoxes3 = serviceBox3,
                Comments = comment,
                OurTeams = ourTeam,
                OurTeamImage1 = ourTeamImage1,
                OurTeamImage2 = ourTeamImage2,
                OurTeamImage3 = ourTeamImage3,
                Pats = pat
            });
        }
        public IActionResult Contact()
        {
            return View();
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
