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
        public ActionResult Index(long? FabId, long? CatId)
        {
            Home h = new Home();
            h.fabr = context.Fabricantes.OrderBy(c => c.Nome);
            h.cate = context.Categorias.OrderBy(c => c.Nome);
            if (FabId != null)
            {
                h.filtro = "Fabricante";
                h.prods = context.Produtos.Where(p => p.FabricanteId == FabId).OrderBy(c => c.Nome);
            }
                
            if (CatId != null)
            {
                h.filtro = "Categoria";
                h.prods = context.Produtos.Where(p => p.CategoriaId == CatId).OrderBy(c => c.Nome);
            }
                
            return View(h);
        }
    }
}