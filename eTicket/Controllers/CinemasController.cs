﻿using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace eTicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;

        public CinemasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var cinemas = _context.Cinemas.ToList();
            return View(cinemas);
        }
    }
}
