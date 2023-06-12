using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Home
    {
        public IEnumerable<Fabricante> fabr;
        public IEnumerable<Categoria> cate;
        public IEnumerable<Produto> prods;
    }
}