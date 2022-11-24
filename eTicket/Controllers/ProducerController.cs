using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTicket.Controllers
{
    public class ProducerController : Controller
    {
        private readonly AppDbContext _context;

        public ProducerController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var producers = _context.Producers.ToList();
            return View(producers);
        }
    }
}
