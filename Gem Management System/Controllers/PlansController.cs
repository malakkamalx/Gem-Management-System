using Gem_Management_System.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gem_Management_System.Controllers
{
    public class PlansController : Controller
    {
        public  async Task<IActionResult> Index()
        {
          GemDbContext dbcontext=new GemDbContext();
          var plans=await dbcontext.Plans.ToArrayAsync();
           return View(plans);
        }

    }
}
