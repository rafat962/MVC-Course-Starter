using Microsoft.AspNetCore.Mvc;
using WebGIS46.Models;
namespace WebGIS46.Controllers
{
    public class ProductController : Controller
    {
        private ProductBL _productBL = new ProductBL();

         
        // Get All Products ==> (Product/all)
        public IActionResult All()
        {
            var products = _productBL.GetAllProducts();
            return View("ShowAllProducts", products);
        }
        // Get خىث Products ==> (Product/ProductDetails/id)
        public IActionResult ProductDetails(int id)
        {
            Product product = _productBL.GetProductById(id);
            return View("ShowOneProduct", product);
        }
        
    }
}
