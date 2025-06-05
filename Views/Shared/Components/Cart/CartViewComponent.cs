using GreenShop.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace GreenShop.Views.Shared.Component.CartViewComponent
{    
    public class CartViewComponent : ViewComponent
    {
        private readonly ICartRepository cartList;
        public CartViewComponent(ICartRepository cartList)
        {
                this.cartList = cartList; 
        }
        public IViewComponentResult Invoke() 
        {
            var cart = cartList.TryGetByUserID(Constants.UserId) == null ? new Cart(Constants.UserId) : cartList.TryGetByUserID(Constants.UserId);
            var productCount = cart?.Amount == 0 ? "" : cart?.Amount.ToString();

            return View("Cart", productCount);
        }
    }
}

