using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Photo1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Photo1.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPhotoRepository _photoRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPhotoRepository photoRepository, ShoppingCart shoppingCart)
        {
            _photoRepository = photoRepository;
            _shoppingCart = shoppingCart;
        }

        // GET: /<controller>/
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetCartTotal()
            };

            return View(sCVM);
        }

        public RedirectToActionResult AddToShoppingCart(int photoId)
        {
            var selectedPhoto = _photoRepository.GetPhotoById(photoId);
            if(selectedPhoto != null)
            {
                _shoppingCart.AddToCart(selectedPhoto, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int photoId)
        {
            var selectedPhoto = _photoRepository.GetPhotoById(photoId);
            if (selectedPhoto != null)
            {
                _shoppingCart.RemoveFromCart(selectedPhoto);
            }
            return RedirectToAction("Index");
        }
    }
}
