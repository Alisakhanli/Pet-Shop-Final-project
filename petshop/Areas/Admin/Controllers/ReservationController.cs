using Miau.Areas.Admin.Model;
using Miau.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miau.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ReservationController : Controller
    {


        private AppDbContext _context;



        public ReservationController(AppDbContext context)

        {
            _context = context;
        }
            public IActionResult Index()
        {
            var reservation = _context.Reservation.ToList();

            return View(reservation);
        }


        [HttpPost]
        public IActionResult Create(PostModel model)
        {
            var reservation = new PostModel
            {
                Note = model.Note,
                CustomerName = model.CustomerName,
                AnimalName = model.AnimalName,
                Mail = model.Mail

                
            };

            _context.Reservation.Add(reservation);

            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
