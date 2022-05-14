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
    public class PetController : Controller
    {

        private AppDbContext _context;



        public PetController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var pets = _context.Pets.ToList();



            return View(pets);
        }

        public IActionResult Create()
        {




            return View();
        }
        [HttpPost]
        public IActionResult Create(Pet model)
        {
            if (string.IsNullOrEmpty(model.CustomerName))
            {
                return RedirectToAction("Index");
            }
            if (string.IsNullOrEmpty(model.AnimalName))
            {
                return RedirectToAction("Index");
            }
            if (string.IsNullOrEmpty(model.Mail))
            {
                return RedirectToAction("Index");
            }
            if (string.IsNullOrEmpty(model.Note))
            {
                return RedirectToAction("Index");
            }
           
            var pet = new Pet
            {
                CustomerName = model.CustomerName,
                AnimalName = model.AnimalName,
                Mail = model.Mail,
                Note = model.Note

            };
            _context.Pets.Add(pet);

            _context.SaveChanges();
            return RedirectToAction("Index");
          
        }
        public IActionResult Update(int id)
        {
            var pet = _context.Pets.Find(id);



            return View(pet);
        }

        [HttpPost]
        public IActionResult Update( int id, Pet model)
        {
            var pet = _context.Pets.Find(id);
            pet.CustomerName = model.CustomerName;
            pet.AnimalName = model.AnimalName;
            pet.Mail = model.Mail;
            pet.Note = model.Note;
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
            var pet = _context.Pets.Find(id);
            _context.Pets.Remove(pet);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}
      
    

