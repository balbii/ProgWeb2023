using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private EFContext context = new EFContext();
        // GET: Home
        public ActionResult Index()
        {
            Home h = new Home();
            h.fabr = context.Fabricantes.OrderBy(c => c.Nome);
            h.cate = context.Categorias.OrderBy(c => c.Nome);
            return View(h);
        }
    }
}