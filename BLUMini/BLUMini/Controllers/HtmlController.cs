using Microsoft.AspNetCore.Mvc;

namespace BLUMini.Controllers
{
    public class HtmlController : Controller
    {
        [Route("AboutUs")]
        public IActionResult AboutUs()
        {
            return View();
        }
        [Route("Blog")]
        public IActionResult Blog()
        {
            return View();
        }
        [Route("BlogDetails")]
        public IActionResult BlogDetails()
        {
            return View();
        }
        [Route("BlogDetailsGallery")]
        public IActionResult BlogDetailsGallery()
        {
            return View();
        }
        [Route("BlogDetailsVideo")]
        public IActionResult BlogDetailsVideo()
        {
            return View();
        }
        [Route("BlogRightSidebar")]
        public IActionResult BlogRightSidebar()
        {
            return View();
        }
        [Route("CartPage")]
        public IActionResult CartPage()
        {
            return View();
        }
        [Route("Checkout")]
        public IActionResult Checkout()
        {
            return View();
        }
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }
        [Route("LoginRegister")]
        public IActionResult LoginRegister()
        {
            return View();
        }
        [Route("MyAccount")]
        public IActionResult MyAccount()
        {
            return View();
        }
        [Route("ProductDetails")]
        public IActionResult ProductDetails()
        {
            return View();
        }
        [Route("Shop")]
        public IActionResult Shop()
        {
            return View();
        }
        [Route("ShopList")]
        public IActionResult ShopList()
        {
            return View();
        }
        [Route("Testimonial")]
        public IActionResult Testimonial()
        {
            return View();
        }
        [Route("WishList")]
        public IActionResult WishList()
        {
            return View();
        }
    }
}
