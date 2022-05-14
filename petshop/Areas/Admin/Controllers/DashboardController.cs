using Miau.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Miau.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context = context;
        }
      
        public async Task<IActionResult> Index()
        {

            return View();
        }
    }
}
