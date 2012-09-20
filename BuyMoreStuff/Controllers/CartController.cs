using System.Linq;
using System.Web.Mvc;
using BuyMoreStuff.Repositories;
using BuyMoreStuff.ViewModels;

namespace BuyMoreStuff.Controllers
{
    public class CartController : Controller
    {
        private CatalogRepository _catalogRepository = new CatalogRepository();
        private CartRepository _cartRepository = new CartRepository();

        public ActionResult Index()
        {
            return View(new CartViewModel
            {
                Cart = _cartRepository.LoadCart(),
                Products = _catalogRepository.GetProducts().ToList()
            });
        }

        [HttpPost]
        public ActionResult Index(CartViewModel viewModel)
        {
            return View(new CartViewModel
            {
                Cart = viewModel.Cart,
                Products = _catalogRepository.GetProducts().ToList()
            });
        }
    }
}
