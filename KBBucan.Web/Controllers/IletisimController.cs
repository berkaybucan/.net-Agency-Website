using KBBucan.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace KBBucan.Web.Controllers
{

    public class IletisimController : Controller
    {
        private readonly ILogger<IletisimController> _logger;
        private readonly KbbWebContext _context;
        public IletisimController(ILogger<IletisimController> logger, KbbWebContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(IletisimFormu iletisimForm)
        {
            _context.IletisimFormus.Add(iletisimForm);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
