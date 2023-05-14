using Composite.CompositePattern;
using Composite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Composite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult CompositeIndex()
        {
            var categories = _context.Categories.Include(b => b.Products).ToList();
            var values = Rekursive(categories, new Category { Name = "First Category", CategoryId = 0 }, new ProductComposite(0, "First Composite"));
            ViewBag.v = values;
            return View();
        }
        public ProductComposite Rekursive(List<Category> categories, Category firstCategory, ProductComposite firstComposite, ProductComposite leaf = null)
        {
            categories.Where(x => x.UpperCategoryId == firstCategory.CategoryId).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryId, y.Name);
                y.Products.ToList().ForEach(x =>
                {
                    productComposite.Add(new ProductComponent(x.ProductId, x.Name));
                });
                if (leaf != null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
