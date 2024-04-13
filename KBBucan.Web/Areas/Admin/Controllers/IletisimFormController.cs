using KBBucan.Web.Controllers;
using KBBucan.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace KBBucan.Web.Areas.Admin.Controllers
{
    public class IletisimFormController : Controller
    {
        private readonly ILogger<IletisimFormController> _logger;
        private readonly KbbWebContext _context;
        public IletisimFormController(ILogger<IletisimFormController> logger, KbbWebContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.IletisimFormlari = _context.IletisimFormus.ToList();
            return View();
        }
    }
}
