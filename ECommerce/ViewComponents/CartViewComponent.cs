﻿using ECommerce.Helper;
using ECommerce.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace ECommerce.ViewComponents
{
    public class CartViewComponent: ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            const string CART_KEY = "MYCART";
            var cart = HttpContext.Session.Get<List<CartItem>>(CART_KEY)?? new List<CartItem>();
            return View("CartPanel", new CartModel
            {
Quantity = cart.Sum(p=>p.SoLuong),
Total = cart.Sum(p=> p.ThanhTien),
            });
        }
    }
}
